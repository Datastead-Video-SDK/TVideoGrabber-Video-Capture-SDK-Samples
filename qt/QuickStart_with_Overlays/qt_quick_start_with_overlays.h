#pragma once

#include <QtWidgets/QMainWindow>
#include "ui_qt_quick_start_with_overlays.h"
#include "TVideoGrabber.h"

class qt_quick_start_with_overlays : public QMainWindow
{
    Q_OBJECT

public:
    qt_quick_start_with_overlays(QWidget *parent = nullptr);
    ~qt_quick_start_with_overlays();

    void OnVideoGrabberLog(TLogType  LogType, const wchar_t* Severity, const wchar_t* InfoMsg);

    void QtOnFrameBitmapCb(TFrameInfo* FrameInfo, TFrameBitmapInfo* BitmapInfo);
    void QtOnFrameProgressCb(unsigned int  FrameNumber, __int64  FrameTime, int  FrameId);

private slots:
    void on_btnStartScreenCapture_clicked();

    void on_btnSartIPCameraPreview_clicked();

    void on_btnResizeWidgetContainer_clicked();

    void on_btnStop_clicked();
private:
    //Ui::QuickStartWithOverlays* ui;
    CVideoGrabber* m_VideoGrabber;

    void GenerateAndApplyGraphicOverlay(int overlayindex, int width, int height, int leftlocation, int toplocation, bool transparent);

private:
    Ui::qt_quick_start_with_overlaysClass ui;
};
