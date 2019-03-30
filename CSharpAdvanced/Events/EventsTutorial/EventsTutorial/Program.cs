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

            // subscribing mailservice's handler to videoencoders event
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);

            // delegate reminder, nothing to do with events
            MyDele quickDelegate = new MyDele(mailService.ChatFirst);
            quickDelegate += mailService.ChatSecond;
            quickDelegate("hi");
            Console.ReadLine();
        }
    }
}
