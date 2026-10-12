program MainDemoFMX;

/// TVideoGrabber FireMonkey MainDemo (Windows only).
/// VidGrab and VidgrabFMX are found through the project search path (Sources folder, ..\..\..\..)
/// or, in the distributed demos, through the library path (VidGrab.dcu, VidgrabFMX.dcu).

uses
  System.StartUpCopy,
  FMX.Forms,
  MainForm in 'MainForm.pas' {frmMainForm},
  miscVideoQuality in 'miscVideoQuality.pas' {frmVideoQuality},
  miscCameraControl in 'miscCameraControl.pas' {frmCameraControl},
  VUMeterConfigForm in 'VUMeterConfigForm.pas' {frmVUMeterConfig},
  FmxDemoHelpers in 'FmxDemoHelpers.pas',
  VidgrabFMX;

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'Datastead TVideoGrabber FireMonkey demo';
  Application.CreateForm(TfrmMainForm, frmMainForm);
  Application.Run;
end.
