using System;

namespace EventsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            video.Title = "My video 1";

            VideoEncoder videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}
