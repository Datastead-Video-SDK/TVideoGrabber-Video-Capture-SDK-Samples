//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include <tchar.h>
//---------------------------------------------------------------------------
USEFORM("MainForm.cpp", frmMainForm);
USEFORM("miscCameraControl.cpp", frmCameraControl);
USEFORM("miscVideoQuality.cpp", frmVideoQuality);
//---------------------------------------------------------------------------
int WINAPI _tWinMain(HINSTANCE, HINSTANCE, LPTSTR, int)
{
	try
	{
		Application->Initialize();
		Application->MainFormOnTaskBar = true;
		Application->CreateForm(__classid(TfrmMainForm), &frmMainForm);
		Application->CreateForm(__classid(TfrmCameraControl), &frmCameraControl);
		Application->CreateForm(__classid(TfrmVideoQuality), &frmVideoQuality);
		Application->Run();
	}
	catch (Exception &exception)
	{
		Application->ShowException(&exception);
	}
	catch (...)
	{
		try
		{
			throw Exception("");
		}
		catch (Exception &exception)
		{
			Application->ShowException(&exception);
		}
	}
	return 0;
}
//---------------------------------------------------------------------------
