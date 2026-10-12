program MainDemo;

uses
  Forms,
  MainForm in 'MainForm.pas' {frmMainForm};

{$R *.RES}

begin
  Application.Initialize;
  Application.Title := 'Datastead TVideoGrabber VCL component demo';
  Application.CreateForm(TfrmMainForm, frmMainForm);
  Application.Run;
end.
