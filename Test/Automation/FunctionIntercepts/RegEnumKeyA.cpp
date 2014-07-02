#include "common.h"


BOOL My_RegEnumKeyA()
{
	HKEY hKey=NULL;
	DWORD dwIndex=NULL;
	LPSTR lpName=NULL;
	DWORD cbName=NULL;
	LONG returnVal_Real = NULL;
	LONG returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = RegEnumKeyA (hKey,dwIndex,lpName,cbName);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = RegEnumKeyA (hKey,dwIndex,lpName,cbName);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}