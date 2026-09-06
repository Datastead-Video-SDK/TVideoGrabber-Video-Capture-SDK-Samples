#include "qt_quick_start_with_overlays.h"

#include <QGraphicsScene>
#include <qt_windows.h>
//#include <QtWinExtras/QtWin>
#include <time.h>
#include "qpainter.h"

void __stdcall OnVideoGrabberLogCb(void* Object, void* Sender, TLogType  LogType, const wchar_t* Severity, const wchar_t* InfoMsg)
{
    ((qt_quick_start_with_overlays*)Sender)->OnVideoGrabberLog(LogType, Severity, InfoMsg);
}

void __stdcall OnFrameBitmapCb(void* Object, void* Sender, TFrameInfo* FrameInfo, TFrameBitmapInfo* BitmapInfo)
{
    ((qt_quick_start_with_overlays*)Sender)->QtOnFrameBitmapCb(FrameInfo, BitmapInfo);
}

void __stdcall OnFrameProgressCb(void* Object, void* Sender, unsigned int  FrameNumber, __int64  FrameTime, int  FrameId)
{
    ((qt_quick_start_with_overlays*)Sender)->QtOnFrameProgressCb(FrameNumber, FrameTime, FrameId);
}

qt_quick_start_with_overlays::qt_quick_start_with_overlays(QWidget *parent)
    : QMainWindow(parent)
{
    ui.setupUi(this);
    srand(time(0));
    m_VideoGrabber = new CVideoGrabber(this); // this is returned as "Sender" parameter by the callbacks to retrieve the current class instance, see OnVideoGrabberLogCb above
    ui.wdgVideoGrabberContainer->setStyleSheet("background-color:black;");
    m_VideoGrabber->SetParentWindow((HWND)ui.wdgVideoGrabberContainer->winId());
    m_VideoGrabber->SetDisplay_Embedded_FitParent(true);
    m_VideoGrabber->SetDisplay_AspectRatio(TAspectRatio::ar_Box);
    m_VideoGrabber->SetOnLog(&OnVideoGrabberLogCb);
    m_VideoGrabber->SetOnFrameBitmap(&OnFrameBitmapCb);
    m_VideoGrabber->SetOnFrameProgress(&OnFrameProgressCb);
}

qt_quick_start_with_overlays::~qt_quick_start_with_overlays()
{}

void qt_quick_start_with_overlays::GenerateAndApplyGraphicOverlay(int overlayindex, int width, int height, int leftlocation, int toplocation, bool transparent)
{
    QColor overlaycolor (rand()%255, rand()%255, rand()%255);
    QImage overlay_pix0 = QImage(width, height, QImage::Format_ARGB32);
    if (transparent) {
        overlay_pix0.fill(Qt::transparent);
    }
    QPainter overlay_painter0 (&overlay_pix0);
    Qt::BrushStyle style = Qt::SolidPattern;
    QBrush brush(overlaycolor, style);
    overlay_painter0.setBrush(brush);
    overlay_painter0.drawEllipse(10, 10, width - 10, height - 10);
    HBITMAP hbitmap = overlay_pix0.toHBITMAP();

    m_VideoGrabber->SetImageOverlay_LeftLocation (overlayindex, leftlocation);
    m_VideoGrabber->SetImageOverlay_TopLocation (overlayindex, toplocation);
    m_VideoGrabber->SetImageOverlayFromHBitmap3(overlayindex, hbitmap, true);

    if (transparent) {
        m_VideoGrabber->SetImageOverlay_Transparent(overlayindex, true);
    }
    m_VideoGrabber->SetImageOverlay_Enabled(overlayindex, true);
}

void qt_quick_start_with_overlays::QtOnFrameProgressCb  (unsigned int  FrameNumber, __int64  FrameTime, int  FrameId)
{
}

void qt_quick_start_with_overlays::QtOnFrameBitmapCb  (TFrameInfo *FrameInfo, TFrameBitmapInfo *BitmapInfo)
{
    GenerateAndApplyGraphicOverlay (0, 100, 150, rand()%m_VideoGrabber->GetVideoWidth(), rand()%m_VideoGrabber->GetVideoHeight(), false);
    GenerateAndApplyGraphicOverlay (1, 400, 400, 100 + rand()%50, 100 + rand()%50, true);
}

/*
qt_quick_start_with_overlays::qt_quick_start_with_overlays(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::QuickStartWithOverlays),
    m_VideoGrabber(NULL)
{
    ui.setupUi(this);
    qsrand(time(0));
    m_VideoGrabber = new CVideoGrabber(this); // this is returned as "Sender" parameter by the callbacks to retrieve the current class instance, see OnVideoGrabberLogCb above
    ui.wdgVideoGrabberContainer->setStyleSheet("background-color:black;");
    m_VideoGrabber->SetParentWindow((HWND)ui.wdgVideoGrabberContainer->winId());
    m_VideoGrabber->SetDisplay_Embedded_FitParent (true);
    m_VideoGrabber->SetDisplay_AspectRatio(TAspectRatio::ar_Box);
    m_VideoGrabber->SetOnLog(&OnVideoGrabberLogCb);
    m_VideoGrabber->SetOnFrameBitmap(&OnFrameBitmapCb);
    m_VideoGrabber->SetOnFrameProgress(&OnFrameProgressCb);
}

qt_quick_start_with_overlays::~QuickStartWithOverlays()
{
    delete m_VideoGrabber;
    delete ui;
}
*/

void qt_quick_start_with_overlays::OnVideoGrabberLog (TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg)
{
    ui.txtLog->append(QString::fromWCharArray(InfoMsg));
}

void qt_quick_start_with_overlays::on_btnStartScreenCapture_clicked()
{
    m_VideoGrabber->SetVideoSource(TVideoSource::vs_ScreenRecording);
    m_VideoGrabber->StartPreview();
    //m_VideoGrabber->SetRecordingMethod(TRecordingMethod::rm_ASF);
    //m_VideoGrabber->StartRecording();
}

void qt_quick_start_with_overlays::on_btnSartIPCameraPreview_clicked()
{
    m_VideoGrabber->SetVideoSource(TVideoSource::vs_IPCamera);
    //m_VideoGrabber->SetAuthentication(at_IPCamera, L"username", L"password"); // if needed
    m_VideoGrabber->SetVideoSource(TVideoSource::vs_Mixer);
    m_VideoGrabber->UseNearestVideoSize(720, 480, true);

    m_VideoGrabber->SetIPCameraURL(L"rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov");
    //m_VideoGrabber->SetAudioDeviceRendering(true); // if audio rendering needed
    m_VideoGrabber->StartPreview();
}

void qt_quick_start_with_overlays::on_btnResizeWidgetContainer_clicked()
{
    ui.wdgVideoGrabberContainer->resize(800, 600);
    m_VideoGrabber->SetDisplay_Embedded_FitParent (true);
}

void qt_quick_start_with_overlays::on_btnStop_clicked()
{
    m_VideoGrabber->Stop();
}

