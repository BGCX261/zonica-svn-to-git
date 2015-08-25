#include <stdio.h>
#include <windows.h>
#include <malloc.h>
#include "winamp.h"

#define METASIZE 128

HWND hwndWinamp;

//returns NULL if alloc failed, returns remote address otherwise
void *AllocWinamp(unsigned long bufsize)
{
	void *remoteBuf;
	HANDLE hWinamp;
	unsigned long dWinamp;

	// find the process id
	GetWindowThreadProcessId(hwndWinamp, &dWinamp);

	// open the process object
	hWinamp = OpenProcess(PROCESS_ALL_ACCESS,false,dWinamp);
	if(hWinamp == NULL) return NULL;

	// allocate chunk of memory in winamp's address space
	remoteBuf = VirtualAllocEx(hWinamp, NULL, bufsize, MEM_COMMIT, PAGE_READWRITE);

	CloseHandle(hWinamp);
	return remoteBuf;
}

// returns 0 on success (it's winamp's problem if it fails... right?)
int FreeWinamp(void *remoteBuf, unsigned long bufsize)
{
	int isError;
	HANDLE hWinamp;
	unsigned long dWinamp;

	// find the process id
	GetWindowThreadProcessId(hwndWinamp, &dWinamp);

	// open the process object
	hWinamp = OpenProcess(PROCESS_ALL_ACCESS,false,dWinamp);
	if(hWinamp == NULL) return 2;
	
	// free the memory in winamp's space
	isError = VirtualFreeEx(hWinamp, remoteBuf, bufsize, MEM_DECOMMIT);
	if(!isError)
	{
		CloseHandle(hWinamp);
		return isError;
	}

	// release it
	isError = VirtualFreeEx(hWinamp, remoteBuf, 0, MEM_RELEASE);
	if(!isError)
	{
		CloseHandle(hWinamp);
		return isError;
	}

	CloseHandle(hWinamp);
	return 0;
}

// returns how many bytes were copied to local buffer
unsigned long ReadWinampToLocal(void *remoteBuf, void *localBuf, unsigned long bufsize)
{
	int isError;
	HANDLE hWinamp;
	unsigned long dWinamp;

	// find the process id
	GetWindowThreadProcessId(hwndWinamp, &dWinamp);

	// open the process object
	hWinamp = OpenProcess(PROCESS_ALL_ACCESS,false,dWinamp);
	if(hWinamp == NULL) return 0;

	isError = ReadProcessMemory(hWinamp, remoteBuf, localBuf, bufsize, NULL);

	CloseHandle(hWinamp);

	if(!isError) return 0;
	else return bufsize;
}

// returns how many bytes were written to winamp's space
unsigned long WriteLocalToWinamp(void *localBuf, void *remoteBuf, unsigned long bufsize)
{
	int isError;
	HANDLE hWinamp;
	unsigned long dWinamp;

	// find the process id
	GetWindowThreadProcessId(hwndWinamp, &dWinamp);

	// open the process object
	hWinamp = OpenProcess(PROCESS_ALL_ACCESS,false,dWinamp);
	if(hWinamp == NULL) return 0;

	isError = WriteProcessMemory(hWinamp, remoteBuf, localBuf, bufsize, NULL);

	CloseHandle(hWinamp);

	if(!isError) return 0;
	else return bufsize;
}
	
int GetPlayingTrack()
{
	return SendMessage(hwndWinamp,WM_WA_IPC,0,IPC_GETLISTPOS);
}

char *GetMetaInfo(char *whichInfo, char *returnVal)
{
	char *remoteBuf, *whichBuf, *structBuf;
	static extendedFileInfoStruct xstruct;

	// allocate the memory in winamp's space
	remoteBuf = (char *)AllocWinamp(METASIZE);
	whichBuf = (char *)AllocWinamp(sizeof(whichInfo));
	structBuf = (char *)AllocWinamp(sizeof(xstruct));

	// fill in ext struct
	xstruct.filename = (char *)SendMessage(hwndWinamp, WM_WA_IPC, GetPlayingTrack(), IPC_GETPLAYLISTFILE);
	xstruct.metadata = whichBuf;
	xstruct.ret = remoteBuf;
	xstruct.retlen = METASIZE;

	// send the "get ext info call"
	if(!SendMessage(hwndWinamp,WM_WA_IPC,(int)structBuf,IPC_GET_EXTENDED_FILE_INFO_HOOKABLE))
	{
		printf("Extended file information not available.\n");
		return "no_ex";
	}
	
	// copy the remote buffer to local space
	ReadWinampToLocal(remoteBuf, returnVal, METASIZE);

	// free up the memory we allocated in winamp's space
	FreeWinamp(remoteBuf, METASIZE);
	FreeWinamp(whichBuf, sizeof(whichBuf));
	FreeWinamp(structBuf, sizeof(xstruct));
	return returnVal;
}

int main(int argc, char* argv[])
{
	char *returnVal;
	char *returnValOld;
	char outFileName[255];
	FILE *outFile;
	int length;

	returnVal = (char *)malloc(MAX_PATH*sizeof(char));
	returnValOld = (char *)malloc(MAX_PATH*sizeof(char));

	strcpy(outFileName,"zonicaOut.txt");

	hwndWinamp = FindWindowA("Winamp v1.x",NULL);
	if(hwndWinamp == NULL)
	{
		printf("Winamp not running.\n");
		return 0;
	}

	while(1)
	{
		ReadWinampToLocal((char *)SendMessage(hwndWinamp, WM_WA_IPC, GetPlayingTrack(), IPC_GETPLAYLISTFILE), returnVal, MAX_PATH);

		if(strcmp(returnVal,returnValOld)) //if track has changed
		{
			strcpy(returnValOld,returnVal);

			

			
			printf("\nCurrently Playing song: %s\n\n", returnVal);
			printf("Artist: %s\n", GetMetaInfo("Artist", returnVal));
			printf("Title: %s\n", GetMetaInfo("Title", returnVal));
			printf("Album: %s\n", GetMetaInfo("Album", returnVal));
			printf("Year: %s\n", GetMetaInfo("Year", returnVal));
			printf("Bitrate: %s kbps\n", GetMetaInfo("Bitrate", returnVal));
			outFile = fopen(outFileName,"at");

			fprintf(outFile,"\nCurrently Playing song: %s\n\n", returnVal);
			fprintf(outFile,"Artist: %s\n", GetMetaInfo("Artist", returnVal));
			fprintf(outFile,"Title: %s\n", GetMetaInfo("Title", returnVal));
			fprintf(outFile,"Album: %s\n", GetMetaInfo("Album", returnVal));
			fprintf(outFile,"Year: %s\n", GetMetaInfo("Year", returnVal));
			fprintf(outFile,"Bitrate: %s kbps\n", GetMetaInfo("Bitrate", returnVal));

			fclose(outFile);

			// in milliseconds
			length = atoi(GetMetaInfo("Length", returnVal));
			printf("Length: %d:%02d\n", length/(1000*60), (length/1000)%60);

			//free(returnVal);
		}
	}

	return 0;
}
