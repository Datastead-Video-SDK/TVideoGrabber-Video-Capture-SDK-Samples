program MainDemo;

uses
  Forms,
  MainForm in 'MainForm.pas' {frmMainForm},
  miscCameraControl in 'miscCameraControl.pas' {frmCameraControl},
  miscVideoQuality in 'miscVideoQuality.pas' {frmVideoQuality};

{$R *.RES}

begin
  Application.Initialize;
  Application.Title := 'Datastead TVideoGrabber VCL component demo';
  Application.CreateForm(TfrmMainForm, frmMainForm);
  Application.CreateForm(TfrmCameraControl, frmCameraControl);
  Application.CreateForm(TfrmVideoQuality, frmVideoQuality);
  Application.Run;
end.
