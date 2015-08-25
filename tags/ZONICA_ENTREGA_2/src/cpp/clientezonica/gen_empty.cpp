#include <windows.h> 
#include <process.h>
#include <stdio.h>
#include "gen_empty.h"
#include <malloc.h>
#include "wa_ipc.h"
//#include "client.cpp"

int init(void); 
void config(void); 
void quit(void);

#define METASIZE 128

extern int sendData(char* pcHost,int nPort, char* data);

char *GetMetaInfo(char *whichInfo, char *returnVal, HWND hwndWinamp)
{
	char structBuf[METASIZE];
	static extendedFileInfoStruct xstruct;

	// fill in ext struct
	xstruct.filename = (char*)SendMessage(hwndWinamp,WM_WA_IPC,SendMessage(hwndWinamp,WM_WA_IPC,0,IPC_GETLISTPOS),IPC_GETPLAYLISTFILE);
	xstruct.metadata = whichInfo;
	xstruct.ret = structBuf;
	xstruct.retlen = METASIZE;

	// send the "get ext info call"
	if(!SendMessage(hwndWinamp,WM_WA_IPC,(int)&xstruct,IPC_GET_EXTENDED_FILE_INFO_HOOKABLE))
	{
		return "no_ex";
	}
	
//	strcpy(returnVal,structBuf);

	return structBuf;
}

winampGeneralPurposePlugin plugin = {
  GPPHDR_VER,
  "MyEmpyProject vx.x (gen_zonica.dll)", // Plug-in description 
  init,
  config, 
  quit,
}; 

WNDPROC WinampProc;
LRESULT CALLBACK HookWinampWnd(HWND hwnd, UINT umsg, WPARAM wp, LPARAM lp)
{
	FILE * outFile;
	static char* filename;
	char *returnVal = NULL;
	static char oldfilename[255];
	int currTime;

	if(lp == IPC_CB_MISC && wp == IPC_CB_MISC_STATUS)
	{
		currTime = SendMessage(hwnd,WM_WA_IPC,0,IPC_GETOUTPUTTIME);
		if(SendMessage(hwnd,WM_WA_IPC,0,IPC_ISPLAYING) == 1 && currTime == 0)
		{
			filename = (char*)SendMessage(hwnd,WM_WA_IPC,SendMessage(hwnd,WM_WA_IPC,0,IPC_GETLISTPOS),IPC_GETPLAYLISTFILE);
			// only output if a valid file was found
			if(filename && strcmp(filename,oldfilename))
			{
				strcpy(oldfilename,filename);
			//	MessageBox(hwnd,file,"starting",0);

				outFile = fopen("c:\\zonica.txt","at");

				fprintf(outFile,"\nCurrently Playing song: %s\n\n", filename);
				fprintf(outFile,"Artist: %s\n", GetMetaInfo("Artist", returnVal, hwnd));
				fprintf(outFile,"Title: %s\n", GetMetaInfo("Title", returnVal, hwnd));
				fprintf(outFile,"Album: %s\n", GetMetaInfo("Album", returnVal, hwnd));
				fprintf(outFile,"Year: %s\n", GetMetaInfo("Year", returnVal, hwnd));

				fclose(outFile);

				sendData("127.0.0.1",4242,filename);

				// or do something else that you need to do
			}
		}
	}

	return CallWindowProc(WinampProc, hwnd, umsg, wp, lp);
}

int init() 
{	
	WinampProc = (WNDPROC)SetWindowLong(plugin.hwndParent, GWL_WNDPROC, (LONG)HookWinampWnd); 
	return 0;

	//MessageBox(plugin.hwndParent,"Init","",MB_OK);
} 

void config() 
{ 
	MessageBox(plugin.hwndParent,"Config","",MB_OK); 
} 

void quit() 
{ 
	SetWindowLong(plugin.hwndParent, GWL_WNDPROC,(LONG)WinampProc); 
  //MessageBox(0,"Quit","",MB_OK); 
} 

extern "C" {

__declspec(dllexport) winampGeneralPurposePlugin * winampGetGeneralPurposePlugin() 
{
	return &plugin; 
}

};