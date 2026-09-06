using System;
using System.Text;

namespace ConsoleApplicationWithoutForms
{
    class Program
    {

        private static System.ConsoleKeyInfo KeyRead, DummyKey;
        private static int VideoDeviceIndex;
        private static VidGrabNoForm.VideoGrabber VideoGrabber;

        static void ContinueUntilKeyPressedOrInactive()
        {
            while ((!Console.KeyAvailable) && (VideoGrabber.CurrentState != VidGrabNoForm.TCurrentState.cs_Down))
            {
                VideoGrabber.ContinueProcessing();
            }
            KeyRead = Console.ReadKey();
        }

        static void VideoGrabber_OnPreviewStarted(object sender, EventArgs e)
        {
            Console.WriteLine("preview started!");
        }

        static void VideoGrabber_OnPlayerOpened(object sender, EventArgs e)
        {
            Console.WriteLine("player opened!");
        }

        static void VideoGrabber_OnInactive(object sender, EventArgs e)
        {
            Console.WriteLine("component inactive.");
        }

        static void VideoGrabber_OnPlayerEndOfStream(object sender, EventArgs e)
        {
            Console.WriteLine("end of stream!");
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
            VideoGrabber.OnPlayerOpened += new EventHandler(VideoGrabber_OnPlayerOpened);
            VideoGrabber.OnPlayerEndOfStream += new EventHandler(VideoGrabber_OnPlayerEndOfStream);

            Console.Clear();
            Console.WriteLine("List of the video capture devices:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(VideoGrabber.VideoDevices.ToString());
            Console.WriteLine("");
            Console.WriteLine("enter the index of the video capture device to use (between 0 and " + (VideoGrabber.VideoDevicesCount - 1).ToString() + ")");
            Console.WriteLine("or press enter to skip");

            VideoGrabber.Display_Embedded = false; // enables the display of the video window when the component has no parent

            KeyRead = Console.ReadKey();
            if (KeyRead.KeyChar != 13)
            {
                DummyKey = Console.ReadKey(); // waits for the user to press "enter"
            }

            VideoDeviceIndex = KeyRead.KeyChar - 48;
            if ((VideoDeviceIndex >= 0) && (VideoDeviceIndex < VideoGrabber.VideoDevicesCount))
            {
                VideoGrabber.VideoDevice = KeyRead.KeyChar - 48; // e.g. ASCII code of the "1" key = 49;
                Console.WriteLine("starting preview...");
                VideoGrabber.StartPreview();
            }
            else if (KeyRead.KeyChar != 13)
            {
                Console.WriteLine("invalid index");
            }

            if (VideoGrabber.CurrentState == VidGrabNoForm.TCurrentState.cs_Preview)
            {
                Console.WriteLine("");
                Console.WriteLine("press a key to capture a frame to a JPEG file in the current folder");

                ContinueUntilKeyPressedOrInactive();
                VideoGrabber.CaptureFrameSyncTo(VidGrabNoForm.TFrameCaptureDest.fc_JpegFile, "");
            }

            Console.WriteLine("");
            Console.WriteLine("press a key to stop the preview...");

            ContinueUntilKeyPressedOrInactive();

            VideoGrabber.StopPreview();

            Console.WriteLine("");
            Console.WriteLine("enter the file name of a video clip to play, or press enter to skip:");
            string PlayerFileName = Console.ReadLine();

            if (PlayerFileName != "")
            {
                VideoGrabber.PlayerFileName = PlayerFileName;
                VideoGrabber.OpenPlayer();
                if (VideoGrabber.CurrentState == VidGrabNoForm.TCurrentState.cs_Playback)
                {
                    Console.WriteLine("");
                    Console.WriteLine("press a key to close the player");
                    ContinueUntilKeyPressedOrInactive();
                    VideoGrabber.ClosePlayer();
                }
                else
                {
                    Console.WriteLine("error: failed to open the player");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("press a key to destroy the component");
            Console.ReadKey();

            VideoGrabber.Dispose();
        }

    }
}

