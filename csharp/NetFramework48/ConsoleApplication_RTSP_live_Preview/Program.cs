using System;
using System.Text;

namespace ConsoleApplicationWithoutForms
{
    class Program
    {

        private static VidGrabNoForm.VideoGrabber VideoGrabber;

        static void VideoGrabber_OnPreviewStarted(object sender, EventArgs e)
        {
            Console.WriteLine("preview started!");
            Console.WriteLine("");
            Console.WriteLine("press [Enter] to stop the preview or any other key to capture a frame...");
        }

        static void VideoGrabber_OnInactive(object sender, EventArgs e)
        {
            Console.WriteLine("component inactive.");
        }

       static void VideoGrabber_OnFrameCaptureCompleted(object sender, VidGrabNoForm.TOnFrameCaptureCompletedEventArgs e)
        {
            if (e.success)
            {
                Console.WriteLine("frame successfully captured to: " + e.fileName);
            }
        }

        static void Main(string[] args)
        {


            VideoGrabber = new VidGrabNoForm.VideoGrabber();
            VideoGrabber.OnPreviewStarted += new EventHandler(VideoGrabber_OnPreviewStarted);
            VideoGrabber.OnInactive += new EventHandler(VideoGrabber_OnInactive);
            VideoGrabber.OnFrameCaptureCompleted += new VidGrabNoForm.OnFrameCaptureCompletedEventHandler(VideoGrabber_OnFrameCaptureCompleted);

            VideoGrabber.VideoSource = VidGrabNoForm.TVideoSource.vs_IPCamera;
            VideoGrabber.IPCameraURL = "rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov";
            VideoGrabber.Display_Embedded = false; // enables the display of the video window when the component has no parent

            // VideoGrabber.OpenURLAsync = false; enable it to start the preview synchronously and block the main thread


            Console.WriteLine("preview starting...");

            VideoGrabber.StartPreview();

            bool Done = false;
            while (!Done)
            {

                while ((!Console.KeyAvailable))
                {
                    VideoGrabber.ContinueProcessing(); /// required
                }
                System.ConsoleKeyInfo KeyRead = Console.ReadKey();
                if (KeyRead.KeyChar != 13)
                {
                    VideoGrabber.CaptureFrameSyncTo(VidGrabNoForm.TFrameCaptureDest.fc_JpegFile, "");
                }
                else
                {
                    Done = true;
                }
            }

            VideoGrabber.StopPreview();

            VideoGrabber.Dispose();
        }

    }
}

