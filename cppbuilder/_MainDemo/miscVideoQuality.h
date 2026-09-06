//---------------------------------------------------------------------------

#ifndef miscVideoQualityH
#define miscVideoQualityH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include "VidGrab.hpp"

#ifndef TypeSettingGroup
#define TypeSettingGroup
typedef struct {
     TTrackBar *tbrValue;
     TCheckBox *chkAuto;
     TButton   *btnDefault;
} TSettingGroup;
#endif

//---------------------------------------------------------------------------
class TfrmVideoQuality : public TForm
{
__published:	// IDE-managed Components
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label3;
        TLabel *Label4;
        TLabel *Label5;
        TLabel *Label6;
        TLabel *Label7;
        TLabel *Label8;
        TButton *btnClose;
        TTrackBar *tbrHue;
        TTrackBar *tbrContrast;
        TTrackBar *tbrSaturation;
        TTrackBar *tbrBrightness;
        TTrackBar *tbrSharpness;
        TTrackBar *tbrGamma;
        TTrackBar *tbrWhiteBalance;
        TCheckBox *chkBrightness;
        TCheckBox *chkContrast;
        TCheckBox *chkHue;
        TCheckBox *chkSaturation;
        TCheckBox *chkSharpness;
        TCheckBox *chkGamma;
        TCheckBox *chkWhiteBalance;
        TButton *btnBrightness;
        TButton *btnContrast;
        TButton *btnHue;
        TButton *btnSaturation;
        TButton *btnSharpness;
        TButton *btnGamma;
        TButton *btnWhiteBalance;
        TTrackBar *tbrGain;
        TButton *btnGain;
        TCheckBox *chkGain;
        TLabel *Label9;
        TTrackBar *tbrBacklight;
        TButton *btnBacklight;
        TCheckBox *chkBacklight;
        TLabel *Label10;
        TTrackBar *tbrColorEnable;
        TButton *btnColorEnable;
        TCheckBox *chkColorEnable;
        void __fastcall OnSetValue (TObject *Sender);
        void __fastcall OnSetDefault (TObject *Sender);
        void __fastcall FormShow(TObject *Sender);
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall btnCloseClick(TObject *Sender);
private:	// User declarations
      BOOL FInitializing;
      TSettingGroup FSettingGroup[vq_Gain + 1]; // vq_BacklightCompensation = index of the last TVideoQuality enum, so vq_BacklightCompensation + 1 = number of TVideoQuality items
      void __fastcall InitTrackBar (TCheckBox *chkAuto, TButton *btnDefault, TTrackBar *tbrValue, TVideoQuality Setting);
      void __fastcall InitTrackBars ();
public:		// User declarations
        __fastcall TfrmVideoQuality(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TfrmVideoQuality *frmVideoQuality;
//---------------------------------------------------------------------------
#endif
