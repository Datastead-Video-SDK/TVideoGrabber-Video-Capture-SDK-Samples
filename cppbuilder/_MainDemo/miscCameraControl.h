//---------------------------------------------------------------------------

#ifndef miscCameraControlH
#define miscCameraControlH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include "VidGrab.hpp"
#include <ExtCtrls.hpp>

#ifndef TypeSettingGroup
#define TypeSettingGroup
typedef struct {
     TTrackBar *tbrValue;
     TCheckBox *chkAuto;
     TButton   *btnDefault;
} TSettingGroup;
#endif

//---------------------------------------------------------------------------
class TfrmCameraControl : public TForm
{
__published:	// IDE-managed Components
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label3;
        TLabel *Label4;
        TLabel *Label5;
        TLabel *Label6;
        TLabel *Label7;
        TTrackBar *tbrTilt;
        TTrackBar *tbrPan;
        TTrackBar *tbrRoll;
        TTrackBar *tbrZoom;
        TTrackBar *tbrExposure;
        TTrackBar *tbrIris;
        TTrackBar *tbrFocus;
        TButton *btnClose;
        TCheckBox *chkZoom;
        TCheckBox *chkPan;
        TCheckBox *chkTilt;
        TCheckBox *chkRoll;
        TCheckBox *chkExposure;
        TCheckBox *chkIris;
        TCheckBox *chkFocus;
        TButton *btnZoom;
        TButton *btnPan;
        TButton *btnTilt;
        TButton *btnRoll;
        TButton *btnExposure;
        TButton *btnIris;
        TButton *btnFocus;
        void __fastcall OnSetValue (TObject *Sender);
        void __fastcall OnSetDefault (TObject *Sender);
        void __fastcall FormShow(TObject *Sender);
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall btnCloseClick(TObject *Sender);
private:	// User declarations
      BOOL FInitializing;
      TSettingGroup FSettingGroup[cc_Focus + 1]; // cc_Focus = index of the last TCameraControl enum, cc_Focus + 1 = number of TCameraControl items
      void __fastcall InitTrackBar (TCheckBox *chkAuto, TButton *btnDefault, TTrackBar *tbrValue, TCameraControl Setting);
      void __fastcall InitTrackBars ();
public:		// User declarations
        __fastcall TfrmCameraControl(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TfrmCameraControl *frmCameraControl;
//---------------------------------------------------------------------------
#endif
