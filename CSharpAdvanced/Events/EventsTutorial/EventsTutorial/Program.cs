using System;

namespace EventsTutorial
{
    class Program
    {
        public delegate string MyDele(string i);

        static void Main(string[] args)
        {

            Video video = new Video();
            video.Title = "My video 1";

            VideoEncoder videoEncoder = new VideoEncoder();
            MailService mailService = new MailService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);

            // delegate reminder, nothing to do with events
            // MyDele quickDelegate = mailService.ChatFirst; // or do = new MeDele(method here);
            // quickDelegate += mailService.ChatSecond;
            // quickDelegate("hi");
            Console.ReadLine();
        }
    }
}
