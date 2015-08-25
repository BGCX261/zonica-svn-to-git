/***********************************************************************
 main.cpp - The main() routine for all the "Basic Winsock" suite of
    programs from the Winsock Programmer's FAQ.  This function parses
    the command line, starts up Winsock, and calls an external function
    called DoWinsock to do the actual work.

 This program is hereby released into the public domain.  There is
 ABSOLUTELY NO WARRANTY WHATSOEVER for this product.  Caveat hacker.
***********************************************************************/

#include <winsock.h>
#include <stdlib.h>
#include <iostream>

using namespace std;

//// Prototypes ////////////////////////////////////////////////////////

int DoWinsock(const char* pcHost, int nPort, char* data, int dataLen);


//// main //////////////////////////////////////////////////////////////

int sendData(char* pcHost,int nPort, char* data)
{
    // Start Winsock up
    WSAData wsaData;
	int nCode;
    if ((nCode = WSAStartup(MAKEWORD(1, 1), &wsaData)) != 0) 
	{
		cerr << "WSAStartup() returned error code " << nCode << "." << endl;
        return 255;
    }

    // Call the main example routine.
    int retval = DoWinsock(pcHost, nPort, data, strlen(data));

    // Shut Winsock back down and take off.
    WSACleanup();
    return retval;
}

