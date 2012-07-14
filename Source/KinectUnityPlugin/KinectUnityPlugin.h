/*
	Description: DLL Principal Class
*/

#pragma once

#include "stdafx.h"
#include <string>

#ifndef KINECTUNITYPLUGIN_API
	#define KINECTUNITYPLUGIN_API extern "C" __declspec(dllexport)
#endif



//Test
KINECTUNITYPLUGIN_API int GetANumber();
KINECTUNITYPLUGIN_API char* GetAString();


