object frmVUMeterConfig: TfrmVUMeterConfig
  Left = 0
  Top = 0
  BorderStyle = bsSizeToolWin
  Caption = 'Configure VU-Meters'
  ClientHeight = 540
  ClientWidth = 470
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Position = poScreenCenter
  OnCreate = FormCreate
  OnShow = FormShow
  TextHeight = 13
  object pcMain: TPageControl
    Left = 8
    Top = 8
    Width = 454
    Height = 488
    ActivePage = tsType
    TabOrder = 0
    object tsType: TTabSheet
      Caption = 'Type && Display'
      object lblVUMeter: TLabel
        Left = 12
        Top = 14
        Width = 73
        Height = 13
        Caption = 'VU Meter type:'
      end
      object cboVUMeter: TComboBox
        Left = 100
        Top = 11
        Width = 230
        Height = 21
        Style = csDropDownList
        TabOrder = 0
        OnChange = cboVUMeterChange
      end
      object grbDisplayOptions: TGroupBox
        Left = 12
        Top = 48
        Width = 426
        Height = 165
        Caption = 'Display options'
        TabOrder = 1
        object chkOverlayOverVideo: TCheckBox
          Left = 16
          Top = 24
          Width = 290
          Height = 17
          Caption = 'Draw VU meter as overlay over the video frame'
          TabOrder = 0
          OnClick = chkOverlayOverVideoClick
        end
        object chkTransparent: TCheckBox
          Left = 16
          Top = 50
          Width = 290
          Height = 17
          Caption = 'Transparent background (overlay mode)'
          TabOrder = 1
          OnClick = chkTransparentClick
        end
        object chkFlipVert: TCheckBox
          Left = 16
          Top = 76
          Width = 200
          Height = 17
          Caption = 'Flip vertically'
          TabOrder = 2
          OnClick = chkFlipVertClick
        end
        object chkFlipHorz: TCheckBox
          Left = 220
          Top = 76
          Width = 200
          Height = 17
          Caption = 'Flip horizontally'
          TabOrder = 3
          OnClick = chkFlipHorzClick
        end
        object chkLogarithmic: TCheckBox
          Left = 16
          Top = 102
          Width = 380
          Height = 17
          Caption = 'Logarithmic scale (PPM-style)'
          TabOrder = 4
          OnClick = chkLogarithmicClick
        end
        object btnDisablePeak: TButton
          Left = 16
          Top = 128
          Width = 380
          Height = 25
          Caption = 
            'Peak indicator disabled (sets vu_PeakHoldMs to 0 in the "Ballist' +
            'ics" tab)'
          TabOrder = 5
          OnClick = btnDisablePeakClick
        end
      end
      object grbOverlayRect: TGroupBox
        Left = 12
        Top = 224
        Width = 426
        Height = 100
        Caption = 'Overlay rect (used when "draw as overlay" is enabled)'
        TabOrder = 2
        object lblOverlayLeft: TLabel
          Left = 16
          Top = 28
          Width = 23
          Height = 13
          Caption = 'Left:'
        end
        object lblOverlayTop: TLabel
          Left = 220
          Top = 28
          Width = 22
          Height = 13
          Caption = 'Top:'
        end
        object lblOverlayWidth: TLabel
          Left = 16
          Top = 62
          Width = 32
          Height = 13
          Caption = 'Width:'
        end
        object lblOverlayHeight: TLabel
          Left = 220
          Top = 62
          Width = 35
          Height = 13
          Caption = 'Height:'
        end
        object edtOverlayLeft: TEdit
          Left = 80
          Top = 24
          Width = 80
          Height = 21
          TabOrder = 0
          Text = '10'
          OnChange = edtOverlayLeftChange
        end
        object edtOverlayTop: TEdit
          Left = 290
          Top = 24
          Width = 80
          Height = 21
          TabOrder = 1
          Text = '10'
          OnChange = edtOverlayTopChange
        end
        object edtOverlayWidth: TEdit
          Left = 80
          Top = 58
          Width = 80
          Height = 21
          TabOrder = 2
          Text = '120'
          OnChange = edtOverlayWidthChange
        end
        object edtOverlayHeight: TEdit
          Left = 290
          Top = 58
          Width = 80
          Height = 21
          TabOrder = 3
          Text = '70'
          OnChange = edtOverlayHeightChange
        end
      end
    end
    object tsLevelsColors: TTabSheet
      Caption = 'Levels && Colors'
      ImageIndex = 1
      object grbWarningPercent: TGroupBox
        Left = 12
        Top = 8
        Width = 426
        Height = 65
        Caption = 'Warning threshold (vu_WarningPercent)'
        TabOrder = 0
        object lblWarningPercentValue: TLabel
          Left = 376
          Top = 28
          Width = 26
          Height = 13
          Alignment = taRightJustify
          Caption = '70 %'
        end
        object tbrWarningPercent: TTrackBar
          Left = 12
          Top = 20
          Width = 360
          Height = 38
          Max = 100
          Frequency = 10
          Position = 70
          TabOrder = 0
          ThumbLength = 16
          OnChange = tbrWarningPercentChange
        end
      end
      object grbPeakPercent: TGroupBox
        Left = 12
        Top = 80
        Width = 426
        Height = 65
        Caption = 'Peak threshold (vu_PeakPercent)'
        TabOrder = 1
        object lblPeakPercentValue: TLabel
          Left = 376
          Top = 28
          Width = 26
          Height = 13
          Alignment = taRightJustify
          Caption = '90 %'
        end
        object tbrPeakPercent: TTrackBar
          Left = 12
          Top = 20
          Width = 360
          Height = 38
          Max = 100
          Frequency = 10
          Position = 90
          TabOrder = 0
          ThumbLength = 16
          OnChange = tbrPeakPercentChange
        end
      end
      object grbColors: TGroupBox
        Left = 12
        Top = 152
        Width = 426
        Height = 200
        Caption = 'Colors'
        TabOrder = 2
        object lblBkgndColor: TLabel
          Left = 16
          Top = 28
          Width = 60
          Height = 13
          Caption = 'Background:'
        end
        object lblNormalColor: TLabel
          Left = 16
          Top = 68
          Width = 37
          Height = 13
          Caption = 'Normal:'
        end
        object lblWarningColor: TLabel
          Left = 16
          Top = 108
          Width = 44
          Height = 13
          Caption = 'Warning:'
        end
        object lblPeakColor: TLabel
          Left = 16
          Top = 148
          Width = 27
          Height = 13
          Caption = 'Peak:'
        end
        object pnBkgndColor: TPanel
          Left = 100
          Top = 22
          Width = 200
          Height = 24
          BevelOuter = bvLowered
          Color = clBlack
          ParentBackground = False
          TabOrder = 0
        end
        object btnBkgndColor: TButton
          Left = 312
          Top = 22
          Width = 90
          Height = 25
          Caption = 'Choose...'
          TabOrder = 1
          OnClick = btnColorClick
        end
        object pnNormalColor: TPanel
          Left = 100
          Top = 62
          Width = 200
          Height = 24
          BevelOuter = bvLowered
          Color = clLime
          ParentBackground = False
          TabOrder = 2
        end
        object btnNormalColor: TButton
          Tag = 1
          Left = 312
          Top = 62
          Width = 90
          Height = 25
          Caption = 'Choose...'
          TabOrder = 3
          OnClick = btnColorClick
        end
        object pnWarningColor: TPanel
          Left = 100
          Top = 102
          Width = 200
          Height = 24
          BevelOuter = bvLowered
          Color = clYellow
          ParentBackground = False
          TabOrder = 4
        end
        object btnWarningColor: TButton
          Tag = 2
          Left = 312
          Top = 102
          Width = 90
          Height = 25
          Caption = 'Choose...'
          TabOrder = 5
          OnClick = btnColorClick
        end
        object pnPeakColor: TPanel
          Left = 100
          Top = 142
          Width = 200
          Height = 24
          BevelOuter = bvLowered
          Color = clRed
          ParentBackground = False
          TabOrder = 6
        end
        object btnPeakColor: TButton
          Tag = 3
          Left = 312
          Top = 142
          Width = 90
          Height = 25
          Caption = 'Choose...'
          TabOrder = 7
          OnClick = btnColorClick
        end
      end
    end
    object tsDrawing: TTabSheet
      Caption = 'Drawing'
      ImageIndex = 2
      object lblTickSize: TLabel
        Left = 16
        Top = 22
        Width = 43
        Height = 13
        Caption = 'Tick size:'
      end
      object lblTickInterval: TLabel
        Left = 16
        Top = 62
        Width = 61
        Height = 13
        Caption = 'Tick interval:'
      end
      object lblNeedleThickness: TLabel
        Left = 16
        Top = 102
        Width = 107
        Height = 13
        Caption = 'Needle thickness (px):'
      end
      object lblDrawingHint: TLabel
        Left = 16
        Top = 160
        Width = 410
        Height = 60
        AutoSize = False
        Caption = 
          'Tick size and tick interval affect mainly the Analog and Analog ' +
          'Vintage meters (length and spacing of the ticks on the arc).'#13#10'Ne' +
          'edle thickness controls the analog meter needle width in pixels.'
        WordWrap = True
      end
      object edtTickSize: TEdit
        Left = 200
        Top = 18
        Width = 60
        Height = 21
        TabOrder = 0
        Text = '6'
        OnChange = edtTickSizeChange
      end
      object updTickSize: TUpDown
        Left = 260
        Top = 18
        Width = 16
        Height = 21
        Associate = edtTickSize
        Min = 1
        Position = 6
        TabOrder = 1
      end
      object edtTickInterval: TEdit
        Left = 200
        Top = 58
        Width = 60
        Height = 21
        TabOrder = 2
        Text = '10'
        OnChange = edtTickIntervalChange
      end
      object updTickInterval: TUpDown
        Left = 260
        Top = 58
        Width = 16
        Height = 21
        Associate = edtTickInterval
        Min = 1
        Position = 10
        TabOrder = 3
      end
      object edtNeedleThickness: TEdit
        Left = 200
        Top = 98
        Width = 60
        Height = 21
        TabOrder = 4
        Text = '2'
        OnChange = edtNeedleThicknessChange
      end
      object updNeedleThickness: TUpDown
        Left = 260
        Top = 98
        Width = 16
        Height = 21
        Associate = edtNeedleThickness
        Min = 1
        Max = 20
        Position = 2
        TabOrder = 5
      end
    end
    object tsBallistics: TTabSheet
      Caption = 'Ballistics'
      ImageIndex = 3
      object lblBallisticProfile: TLabel
        Left = 16
        Top = 22
        Width = 64
        Height = 13
        Caption = 'Quick preset:'
      end
      object lblAttackMs: TLabel
        Left = 16
        Top = 70
        Width = 59
        Height = 13
        Caption = 'Attack (ms):'
      end
      object lblReleaseMs: TLabel
        Left = 16
        Top = 110
        Width = 66
        Height = 13
        Caption = 'Release (ms):'
      end
      object lblPeakHoldMs: TLabel
        Left = 16
        Top = 150
        Width = 74
        Height = 13
        Caption = 'Peak hold (ms):'
      end
      object lblBallisticHint: TLabel
        Left = 16
        Top = 210
        Width = 410
        Height = 130
        AutoSize = False
        Caption = 
          'Pick a preset to fill the three values at once, or tweak them ma' +
          'nually.'#13#10#13#10'* Attack: time constant for level rises (lower = peak' +
          'ier).'#13#10'* Release: time constant for level falls (lower = bouncie' +
          'r).'#13#10'* Peak hold: time the peak LED stays lit after a peak (0 di' +
          'sables it).'#13#10#13#10'Defaults: 10 / 300 / 800 ms (dynamic, snappy look' +
          ').'
        WordWrap = True
      end
      object cboBallisticProfile: TComboBox
        Left = 120
        Top = 18
        Width = 280
        Height = 21
        Style = csDropDownList
        TabOrder = 0
        OnChange = cboBallisticProfileChange
      end
      object edtAttackMs: TEdit
        Left = 200
        Top = 66
        Width = 80
        Height = 21
        TabOrder = 1
        Text = '10'
        OnChange = edtAttackMsChange
      end
      object updAttackMs: TUpDown
        Left = 280
        Top = 66
        Width = 16
        Height = 21
        Associate = edtAttackMs
        Max = 10000
        Position = 10
        TabOrder = 2
      end
      object edtReleaseMs: TEdit
        Left = 200
        Top = 106
        Width = 80
        Height = 21
        TabOrder = 3
        Text = '300'
        OnChange = edtReleaseMsChange
      end
      object updReleaseMs: TUpDown
        Left = 280
        Top = 106
        Width = 16
        Height = 21
        Associate = edtReleaseMs
        Max = 10000
        Position = 300
        TabOrder = 4
      end
      object edtPeakHoldMs: TEdit
        Left = 200
        Top = 146
        Width = 80
        Height = 21
        TabOrder = 5
        Text = '800'
        OnChange = edtPeakHoldMsChange
      end
      object updPeakHoldMs: TUpDown
        Left = 280
        Top = 146
        Width = 16
        Height = 21
        Associate = edtPeakHoldMs
        Max = 10000
        Position = 800
        TabOrder = 6
      end
    end
  end
  object btnRefresh: TButton
    Left = 8
    Top = 506
    Width = 169
    Height = 25
    Caption = 'Refresh from TVideoGrabber'
    TabOrder = 1
    OnClick = btnRefreshClick
  end
  object btnClose: TButton
    Left = 376
    Top = 506
    Width = 86
    Height = 25
    Caption = 'Close'
    TabOrder = 2
    OnClick = btnCloseClick
  end
  object ColorDialog1: TColorDialog
    Left = 200
    Top = 504
  end
end
