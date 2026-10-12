unit VideoFromTBitmaps_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ExtCtrls, VidGrab;

Type
  TForm1 = class(TForm)
    GroupBox1: TGroupBox;
    GroupBox2: TGroupBox;
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
    Image4: TImage;
    Label2: TLabel;
    VideoGrabber: TVideoGrabber;
    btnStartPreview: TButton;
    btnStartRecording: TButton;
    btnStop: TButton;
    mmoLog: TMemo;
    btnPlay: TButton;
    edtFrameProgress: TEdit;
    edtRecordingFrameRate: TEdit;
    chkUseFrameCallback: TCheckBox;
    chkUseBitmapCopy: TCheckBox;
    tmr_SendNextBitmap: TTimer;
    chkSyncPreview: TCheckBox;
    Label1: TLabel;
    procedure btnStartPreviewClick(Sender: TObject);
    procedure btnStartRecordingClick(Sender: TObject);
    procedure btnStopClick(Sender: TObject);
    procedure VideoGrabberLog(Sender: TObject; LogType: TLogType; Severity,
      InfoMsg: String);
    procedure btnPlayClick(Sender: TObject);
    procedure VideoGrabberPreviewStarted(Sender: TObject);
    procedure VideoGrabberInactive(Sender: TObject);
    procedure VideoGrabberRecordingStarted(Sender: TObject;
      FileName: String);
    procedure VideoGrabberRecordingCompleted(Sender: TObject;
      FileName: String; Success: Boolean);
    procedure VideoGrabberPlayerOpened(Sender: TObject);
    procedure VideoGrabberFrameProgress(Sender: TObject; FrameNumber: Cardinal;
      FrameTime: int64; FrameId: Integer);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure FormCreate(Sender: TObject);
    procedure chkUseFrameCallbackClick(Sender: TObject);
    procedure chkUseBitmapCopyClick(Sender: TObject);
    procedure tmr_SendNextBitmapTimer(Sender: TObject);
    procedure chkSyncPreviewClick(Sender: TObject);
  private
      m_ImageIndex: Integer;
      m_UseFrameCallback: Boolean;
      m_UseBitmapCopy: Boolean;
      m_SyncPreview: Boolean;

      procedure VideoGrabberVideoFromBitmapsNextFrameNeeded(Sender: TObject; FirstSample: Boolean);
      function GetNextbitmap (MakeBitmapCopy: Boolean): TBitmap;
      procedure SendNextBitmap();
		procedure InitializeVideoGrabber();
		procedure GenerateBitmaps();
  public
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

procedure TForm1.FormCreate(Sender: TObject);
begin
	m_UseFrameCallback := chkUseFrameCallback.Checked;
   m_UseBitmapCopy := chkUseBitmapCopy.Checked;
   m_SyncPreview := chkSyncPreview.Checked;
   m_ImageIndex := 0;
   GenerateBitmaps();
end;

procedure TForm1.InitializeVideoGrabber();
begin
   VideoGrabber.Stop();
   VideoGrabber.VideoSource := vs_JPEGsOrBitmaps;
   VideoGrabber.FrameRate := StrToIntDef (edtRecordingFrameRate.Text, 10);
   if m_SyncPreview then begin
      VideoGrabber.SyncPreview := sp_Enabled;
   end
   else begin
      VideoGrabber.SyncPreview := sp_Disabled;
   end;

   if m_UseFrameCallback then begin
   	tmr_SendNextBitmap.Enabled := false;
      VideoGrabber.OnVideoFromBitmapsNextFrameNeeded := VideoGrabberVideoFromBitmapsNextFrameNeeded;
   end
   else begin
      VideoGrabber.OnVideoFromBitmapsNextFrameNeeded := nil;
      SendNextBitmap;
      tmr_SendNextBitmap.Enabled := true;
   end;
end;

procedure TForm1.btnStartPreviewClick(Sender: TObject);
begin
   InitializeVideoGrabber();
   VideoGrabber.StartPreview();
end;

procedure TForm1.btnStartRecordingClick(Sender: TObject);
begin
   InitializeVideoGrabber();
   VideoGrabber.Encoder_SetStr (ENCODER_RECORDING_ID, Enc_Video_Codec, 'hevc'); // can be 'h264', etc...
   VideoGrabber.Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_Quality_min, 12);
   VideoGrabber.Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_Quality_max, 42);
   VideoGrabber.Encoder_SetInt (ENCODER_RECORDING_ID, Enc_Video_GPU_Encoder, Integer (Enc_GPU_Auto)); /// uses a GPU encoder if available
   VideoGrabber.RecordingMethod := rm_MP4;
   VideoGrabber.RecordingFileName := ''; // if no file path/name specified, the file name is generated automatically in the VideoGrabber.StoragePath folder (by default the %temp% folder)
   VideoGrabber.StartRecording();
end;

function MakeBitmapCopy (SourceBitmap: TBitmap): TBitmap;
var
   DC: HDC;
begin
  	Result := TBitmap.Create;
   Result.PixelFormat := SourceBitmap.PixelFormat;
   Result.SetSize(SourceBitmap.Width, SourceBitmap.Height);
   DC := CreateCompatibleDC(0);
   SelectObject(DC, Result.Handle);
   SourceBitmap.Canvas.Lock;
   Result.Canvas.Lock;
   BitBlt(DC, 0, 0, SourceBitmap.Width, SourceBitmap.Height, SourceBitmap.Canvas.Handle, 0, 0, SRCCOPY);
   Result.Canvas.Unlock;
   SourceBitmap.Canvas.UnLock;
   DeleteDC(DC);
end;

procedure TForm1.VideoGrabberVideoFromBitmapsNextFrameNeeded(
  Sender: TObject; FirstSample: Boolean); // event callback used to send the bitmap upon TVideoGrabber request for next bitmap ("frame callback" checkbox is checked)
begin
   SendNextBitmap();
end;

procedure TForm1.tmr_SendNextBitmapTimer(Sender: TObject); // timer event used to send the bitmap at the user's initiative ("frame callback" checkbox UNchecked)
begin
  SendNextBitmap();
end;

procedure TForm1.SendNextBitmap();
var
   NextBitmap: TBitmap;
   BitmapCopy: TBitmap;
begin
   NextBitmap := GetNextBitmap (m_UseBitmapCopy);
   if assigned (NextBitmap) then begin
      if m_UseBitmapCopy then begin
         BitmapCopy := MakeBitmapCopy (NextBitmap);
         // as this bitmap is a copy, the 2nd parameter "true" tells TVideoGrabber that it can free the bitmap handle when it has done
   		VideoGrabber.SendImageToVideoFromBitmaps ('', BitmapCopy.Handle, true, false);
         Bitmapcopy.ReleaseHandle;
         Bitmapcopy.Free;
      end
      else begin
         // the 2nd parameter "false" tells TVideoGrabber not to free this bitmap, as we need it again later
   		VideoGrabber.SendImageToVideoFromBitmaps ('', NextBitmap.Handle, false, false);
      end;
   end
   else begin
		VideoGrabber.SendImageToVideoFromBitmaps ('', 0, false, true); // end of stream
   end
end;

procedure TForm1.btnStopClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TForm1.chkSyncPreviewClick(Sender: TObject);
begin
  m_SyncPreview := chkSyncPreview.Checked;
end;

procedure TForm1.chkUseBitmapCopyClick(Sender: TObject);
begin
   m_UseBitmapCopy := chkUseBitmapCopy.Checked;
end;

procedure TForm1.chkUseFrameCallbackClick(Sender: TObject);
begin
   m_UseFrameCallback := chkUseFrameCallback.Checked;
   if (m_UseFrameCallback) then begin
   	VideoGrabber.OnVideoFromBitmapsNextFrameNeeded := VideoGrabberVideoFromBitmapsNextFrameNeeded
   end
   else begin
   	VideoGrabber.OnVideoFromBitmapsNextFrameNeeded := nil;
   end;
end;


procedure TForm1.btnPlayClick(Sender: TObject);
begin
   VideoGrabber.PlayerFileName := VideoGrabber.Last_Recording_FileName;
   VideoGrabber.OpenPlayer;
end;

procedure TForm1.VideoGrabberFrameProgress(Sender: TObject;
  FrameNumber: Cardinal; FrameTime: int64; FrameId: Integer);
begin
   edtFrameProgress.Text := 'frame # ' + IntToStr (FrameNumber);
end;

procedure TForm1.VideoGrabberLog(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
begin
   mmoLog.Lines.Add (InfoMsg);
end;

procedure TForm1.VideoGrabberPreviewStarted(Sender: TObject);
begin
   mmoLog.Lines.Add ('previewing');
end;

procedure TForm1.VideoGrabberInactive(Sender: TObject);
begin
   mmoLog.Lines.Add ('done.');
end;

procedure TForm1.VideoGrabberRecordingStarted(Sender: TObject;
  FileName: String);
begin
   mmoLog.Lines.Add ('recording to: ' + FileName);
end;

procedure TForm1.VideoGrabberRecordingCompleted(Sender: TObject;
  FileName: String; Success: Boolean);
begin
   if Success then begin
      mmoLog.Lines.Add ('recording completed: ' + FileName);
   end
   else begin
      mmoLog.Lines.Add ('recording failed: ' + FileName);
   end;
end;

procedure TForm1.VideoGrabberPlayerOpened(Sender: TObject);
begin
   mmoLog.Lines.Add ('playing ' + VideoGrabber.PlayerFileName);
end;

function TForm1.GetNextbitmap (MakeBitmapCopy: Boolean): TBitmap;
begin
   case m_ImageIndex of
      0: Result := Image1.Picture.Bitmap;
      1: Result := Image2.Picture.Bitmap;
      2: Result := Image3.Picture.Bitmap;
      3: Result := Image4.Picture.Bitmap;
      else Result := Image1.Picture.Bitmap;
   end;
   inc (m_ImageIndex);
   if m_ImageIndex = 4 then begin
      m_ImageIndex := 0;
   end;
end;

procedure TForm1.GenerateBitmaps();
var
  Bitmap: TBitmap;
begin
  Bitmap := TBitmap.Create;
  Bitmap.PixelFormat := pf32Bit;
  Bitmap.SetSize (1280, 720);

  Bitmap.Canvas.Brush.Color := clGray;
  Bitmap.Canvas.Pen.Color := clRed;
  Bitmap.Canvas.Pen.Width := 10;

  Bitmap.Canvas.FillRect(Rect(0, 0, Bitmap.Width, Bitmap.Height));
  Bitmap.Canvas.MoveTo(0, Bitmap.Height div 2);
  Bitmap.Canvas.LineTo(Bitmap.Width, Bitmap.Height div 2);
  Image1.Picture.Bitmap := Bitmap;

  Bitmap.Canvas.FillRect(Rect(0, 0, Bitmap.Width, Bitmap.Height));
  Bitmap.Canvas.MoveTo(0, 0);
  Bitmap.Canvas.LineTo(Bitmap.Width, Bitmap.Height);
  Image2.Picture.Bitmap := Bitmap;

  Bitmap.Canvas.FillRect(Rect(0, 0, Bitmap.Width, Bitmap.Height));
  Bitmap.Canvas.MoveTo(Bitmap.Width div 2, 0);
  Bitmap.Canvas.LineTo(Bitmap.Width div 2, Bitmap.Height);
  Image3.Picture.Bitmap := Bitmap;

  Bitmap.Canvas.FillRect(Rect(0, 0, Bitmap.Width, Bitmap.Height));
  Bitmap.Canvas.MoveTo(Bitmap.Width, 0);
  Bitmap.Canvas.LineTo(0, Bitmap.Height);
  Image4.Picture.Bitmap := Bitmap;

  Bitmap.Free;
end;

procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
   VideoGrabber.Stop();
end;

end.
