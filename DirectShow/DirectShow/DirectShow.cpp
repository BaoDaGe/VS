// DirectShow.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <Dshow.h>
#pragma comment(lib,"Strmiids.lib")  
int _tmain(int argc, _TCHAR* argv[])
{
	HRESULT hr = CoInitialize(NULL);
	if (FAILED(hr))
	{
		// Add error-handling code here. (Omitted for clarity.)
	}
	IGraphBuilder *pGraph;
	hr = CoCreateInstance(CLSID_FilterGraph, NULL,
		CLSCTX_INPROC_SERVER, IID_IGraphBuilder, (void **)&pGraph);
	IMediaControl *pControl;
	IMediaEvent   *pEvent;
	hr = pGraph->QueryInterface(IID_IMediaControl, (void **)&pControl);
	hr = pGraph->QueryInterface(IID_IMediaEvent, (void **)&pEvent);
	hr = pGraph->RenderFile(L"C:\\Program Files\\MATLAB\\R2010a\\toolbox\\vipblks\\vipdemos\\cat_video.avi", NULL);
	hr = pControl->Run();
	long evCode = 0;
	pEvent->WaitForCompletion(INFINITE, &evCode);
	pControl->Release();
	pEvent->Release();
	pGraph->Release();
	CoUninitialize();
	return 0;
}

