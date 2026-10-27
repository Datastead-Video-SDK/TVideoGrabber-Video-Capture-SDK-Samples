# TVideoGrabber video capture SDK samples: Delphi, C++Builder, C++, Qt, C#, VB.NET, Java and VB6

Sample projects for [TVideoGrabber](https://www.datastead.com/video-sdk/), the Datastead video capture SDK for Windows 10/11: capture, recording, streaming and playback component.

The samples cover USB webcams and capture devices, IP cameras (RTSP, RTMP, HTTP, ONVIF), screen capture, video mixing, frame grabbing, re-encoding, RTSP server and playback, in **Delphi** (VCL and FireMonkey), **C++Builder**, **Visual C++ (MSVC)**, **MinGW**, **MFC**, **Qt**, **C#** and **VB.NET** (.NET Framework and .NET Core/.NET 5+, WinForms, WPF, console), **Java** (Swing, JavaFX, headless) and **VB6** (ActiveX).

- Product page: https://www.datastead.com/video-sdk/
- Documentation: https://www.datastead.com/docs/vidgrab/
- API reference: https://www.datastead.com/docs/vidgrab/api/types.html
- Changelog: https://www.datastead.com/video-sdk/tvideograbber-sdk-changelog/
- FAQ: https://www.datastead.com/faq/
- NuGet package (.NET): https://www.nuget.org/packages/TVideoGrabber-SDK

Current SDK version: **17.1.2.0** ([changelog](https://www.datastead.com/video-sdk/tvideograbber-sdk-changelog/)).

## Prerequisites

1. Download and install the TVideoGrabber SDK evaluation version from https://www.datastead.com/downloads/ (fully functional, with a nag screen). For .NET you can also add the [TVideoGrabber-SDK](https://www.nuget.org/packages/TVideoGrabber-SDK) NuGet package.
2. Install the component or wrapper for your IDE (see the [installation guide](https://www.datastead.com/docs/vidgrab/guide/native-vcl-version-for-delphi-c-builder.html) for Delphi and C++Builder). The SDK ships x86 and x64 binaries; either copy the `x86`/`x64` folder next to your executable or point `ExtraDLLPath` to it ([prerequisites](https://www.datastead.com/docs/vidgrab/guide/prerequisites.html)).
3. For IP cameras and URL sources, the [RTSP/RTMP/HTTP/ONVIF DirectShow Source Filter](https://www.datastead.com/rtsp-rtmp-http-onvif-directshow-source-filter/) is required (included in the SDK download).
4. For H.264/HEVC recording and streaming, including NVIDIA/AMD/Intel hardware encoders, the [Multipurpose DirectShow Encoder](https://www.datastead.com/multipurpose-directshow-encoder/) is required (included in the SDK download).
5. For file playback, the [LAV Filters](https://github.com/Nevcairiel/LAVFilters/releases) are recommended.

Supported compilers: Delphi and C++Builder from version 4 to the current RAD Studio release, Visual Studio (MSVC), MinGW 32/64, Qt (MSVC or MinGW kits), .NET Framework 3.5 to 4.8.1 and .NET Core 3.0 to .NET 10, Java 8+, VB6. See the [product page](https://www.datastead.com/video-sdk/) for the up-to-date list.

The projects are the samples shipped in the SDK (`_DEMOS` folders of the SDK distribution), refreshed at each release (the exact SDK version they come from is in `SDK_VERSION.txt`). Some of them reference the SDK files (`TVideoGrabber.h`/`.cpp`, `VideoGrabberNET.dll`) with relative paths valid inside the SDK folder tree: after cloning, adjust these references to your SDK installation folder.

## Repository layout

| Folder | Language / toolchain |
|---|---|
| [`delphi/`](delphi) | Delphi (VCL and FireMonkey), Delphi XE and later; older Delphi versions (up to XE) in [`delphi/legacy/`](delphi/legacy). |
| [`cppbuilder/`](cppbuilder) | C++Builder (VCL). Same component, properties and methods as Delphi: the Delphi projects are also a reference for C++Builder. |
| [`cpp/`](cpp) | Visual C++ (MSVC), MFC, MinGW, using the `TVideoGrabber.h` / `TVideoGrabber.cpp` C++ wrapper (no VCL, no .NET, no COM registration). |
| [`qt/`](qt) | Qt, same C++ wrapper. |
| [`csharp/`](csharp) | C#: .NET Framework (WinForms, WPF, console) and .NET Core / .NET 5+ (WinForms, WPF). |
| [`vbnet/`](vbnet) | VB.NET, .NET Framework. |
| [`java/`](java) | Java: Swing, JavaFX and headless (Maven projects). |
| [`vb6/`](vb6) | Visual Basic 6 (ActiveX version of the component). |

## Delphi samples (`delphi/`)

Projects for Delphi XE and later. The same VCL projects for older Delphi versions (up to XE), without the FireMonkey demo, are in [`delphi/legacy/`](delphi/legacy).

| Folder | What it shows |
|---|---|
| `_MainDemo` | Full-featured demo: video sources, preview, recording, IP cameras, camera control, video quality, special controls. Start here. |
| `_MainDemoFMX` | FireMonkey (FMX) version of the main demo, Windows only (`VidgrabFMX` unit). |
| `CreatedAtRuntime/Webcam` | Creating the component at runtime (no DFM) to preview and record a webcam. |
| `CreatedAtRuntime/IP_Camera_or_URL` | Creating the component at runtime to open an IP camera or URL source. |
| `FrameCapture` | Capturing frames from a capture device: single frames and burst mode (`CaptureFrameTo`, `BurstMode`, `BurstInterval`, `BurstCount`). |
| `IPCameraMixer` | Mixing several IP cameras into one mosaic (`Mixer_AddToMixer`, `Mixer_MosaicLines/Columns`) and recording the mosaic. |
| `IPCamera_Mosaic_Streaming_to_UDP` | Same mosaic, streamed to UDP with the Multipurpose Encoder (`Encoders_CreateInstanceForStreaming`). |
| `PictureInPictureMixer` | Picture-in-picture from two sources (webcam, player) with `Mixer_SetupPIPFromSource`. |
| `PlayerControlByFrame` | Frame-accurate player control: `PlayerFramePosition`, pause/step, `UseClock`. |
| `StreamInterface` | Opening a source from a stream interface (`StreamInterface_Format`, `StreamInterface_FrameRate`, `StreamInterface_IsRealTime`). |
| `Surveillance4Webcams` | Four webcams previewed simultaneously, one component per camera. |
| `VideoFromBMPorJPEGfiles` | Building a video from a folder of BMP/JPEG files. |
| `VideoFromTBitmaps` | Building a video from TBitmap objects generated at runtime. |
| `Multipurpose_Merge_Clips_SideBySide` | Re-encoding two clips side by side with the Multipurpose Encoder (`StartReencoding`, `Reencoding_NewVideoClip`). |

## C++Builder samples (`cppbuilder/`)

| Folder | What it shows |
|---|---|
| `_MainDemo` | Full-featured C++Builder demo (VCL): video sources, preview, recording, IP cameras, camera control, video quality. |

## C++ samples (`cpp/`)

Copy `TVideoGrabber.h` and `TVideoGrabber.cpp` from the SDK into the project folder (or fix the include path), and the x86 or x64 `TVideoGrabber.dll` next to the executable.

| Folder | Toolchain | What it shows |
|---|---|---|
| `MSVC_CppQuickStart` | Visual Studio | Quick start: preview a device, record, play a clip, `OnFrameBitmap` callback. |
| `MSVC_OpenPlayer` | Visual Studio | Minimal player: open and play a clip with `OpenPlayer`, `OnPlayerOpened`. |
| `MSVC_OpenCV` | Visual Studio + OpenCV | RTSP camera preview with frames delivered to OpenCV through `OnFrameBitmap`. |
| `MFCForm` | Visual Studio, MFC | Embedding the video window in an MFC dialog (`SetParentWindow`, `StartPreview`). |
| `MinGW` | MinGW 32/64, `make` | Minimal build with the MinGW toolchain (see `README.html`). |

## Qt samples (`qt/`)

| Folder | What it shows |
|---|---|
| `RTSP_Preview` | RTSP/IP camera preview in a Qt widget. |
| `Webcam_Streaming` | Webcam capture streamed over the network. |
| `QuickStart_with_Overlays` | IP camera preview with image overlays, authentication, logging and frame callbacks. |

## C# samples (`csharp/`)

| Folder | Target | What it shows |
|---|---|---|
| `NetFramework48/_MainDemo` | .NET Framework 4.8, WinForms | Full-featured demo: video sources, preview, recording, IP cameras, streaming, motion detection, overlays, frame grabbing, re-encoding. Start here. |
| `NetFramework48/ComponentCreatedProgrammatically` | .NET Framework 4.8 | Creating the component in code instead of the designer. |
| `NetFramework48/ConsoleApplicationWithoutForms` | .NET Framework 4.8, console | Using the component without any form (headless capture/recording). |
| `NetFramework48/ConsoleApplication_RTSP_live_Preview` | .NET Framework 4.8, console | RTSP camera preview from a console application. |
| `NetFramework48/IPCameraDemo` | .NET Framework 4.8, WinForms | Connecting to an IP camera (RTSP/ONVIF), preview and recording. |
| `NetFramework48/RTSPMultiCamDemo` | .NET Framework 4.8, WinForms | Several RTSP cameras previewed at the same time. |
| `NetFramework48/Multiple_IP_cameras_Switching_While_Non-stop_Recording` | .NET Framework 4.8 | Switching between several IP cameras while the recording continues without interruption. |
| `NetFramework48/Record_4_IP_Cameras_To_OneFile` | .NET Framework 4.8, WinForms | Four IP cameras mixed into one mosaic and recorded to a single file. |
| `NetFramework48/ScreenToRTSPServer/Screen_To_RTSP_Server` | .NET Framework 4.8 | Screen capture published as an RTSP server. |
| `NetFramework48/ScreenWithWebcamPIP` | .NET Framework 4.8 | Screen recording with a webcam picture-in-picture. |
| `NetFramework48/StreamInterface` | .NET Framework 4.8 | Opening a source from a .NET stream interface. |
| `NetFramework48/ThreadedPlaylist` | .NET Framework 4.8 | Playing a playlist from a worker thread. |
| `NetFramework48/convert_avi_to_mp4` | .NET Framework 4.8 | File conversion AVI to MP4 with the Multipurpose Encoder. |
| `NetFramework48/Reencode_video_with_Multipurpose_Encoder` | .NET Framework 4.8 | Re-encoding a video clip with the Multipurpose Encoder. |
| `Console/GrabFirstFrame` | console | Grabbing the first frame of a video file. |
| `Console/Images2Video_with_Multipurpose_Encoder` | console | Building a video from a sequence of images. |
| `Console/Video2Images_with_Multipurpose_Encoder` | console | Extracting the frames of a video to image files. |
| `WPF/MainDemo` | .NET Framework 4.8, WPF | Main demo hosted in WPF. |
| `WPF/WPFDemo (ImageSource)` | .NET Framework 4.8, WPF | Rendering frames into a WPF `ImageSource`. |
| `NetCore/WinForm/MainDemo` | .NET Core / .NET 5+ (Visual Studio 2022) | Main demo, WinForms (see `NetCore/Readme.html`). |
| `NetCore/WPF/MainDemo_WPF` | .NET Core / .NET 5+ (Visual Studio 2022) | Main demo hosted in WPF. |
| `NetCore/WPF/Rendering_in_Image_Control` | .NET Core / .NET 5+ (Visual Studio 2022) | Rendering the video frames in a WPF `Image` control. |

## VB.NET samples (`vbnet/NetFramework48/`)

| Folder | What it shows |
|---|---|
| `_MainDemo` | Full-featured VB.NET demo. |
| `4Cameras` | Four cameras previewed simultaneously. |
| `ComponentCreatedProgrammatically` | Creating the component in code. |
| `ConsoleApplicationWithoutForms` | Headless usage from a console application. |
| `StreamDestkopOrCameraToSocialNetwork` | Streaming the desktop or a camera to a social network (RTMP), see also `vbnet/Code_Snippets/`. |

## Java samples (`java/`)

The Java binding (`tvideograbber.jar`) is included in the SDK. The projects are Maven projects, open them in IntelliJ IDEA, Eclipse or NetBeans.

| Folder | What it shows |
|---|---|
| `Java_Swing/Swing_Demo` | Swing demo: video sources, preview, recording. |
| `Java_FX/FX_4_Cameras` | JavaFX demo previewing four cameras. |
| `Java/headless-4cams` | Headless (no UI) capture/recording of four cameras. |

## VB6 samples (`vb6/`)

| Folder | What it shows |
|---|---|
| `MainDemo` | Full-featured demo using the ActiveX version of the component (`vidgrab_VB6.ocx`), see `ReadmeFirst.html`. |

## Related Datastead products

| Product | Docs |
|---|---|
| [RTSP/RTMP/HTTP/ONVIF DirectShow Source Filter](https://www.datastead.com/rtsp-rtmp-http-onvif-directshow-source-filter/) | [docs/rtsp](https://www.datastead.com/docs/rtsp/) |
| [Multipurpose DirectShow Encoder](https://www.datastead.com/multipurpose-directshow-encoder/) | [docs/multi](https://www.datastead.com/docs/multi/) |
| [NDI DirectShow Filters](https://www.datastead.com/ndi-filters/) | [docs/ndi](https://www.datastead.com/docs/ndi/) |

## Support

Questions about the samples or the SDK: https://www.datastead.com/sample-code-and-support/ or https://www.datastead.com/contact/.

## License

The sample code in this repository is released under the [MIT License](LICENSE). The TVideoGrabber SDK itself is a commercial product distributed under its own [license agreement](https://www.datastead.com/license-agreement/); it is not included in this repository.
