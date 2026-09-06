#include "qt_quick_start_with_overlays.h"
#include <QtWidgets/QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    qt_quick_start_with_overlays w;
    w.show();
    return a.exec();
}
