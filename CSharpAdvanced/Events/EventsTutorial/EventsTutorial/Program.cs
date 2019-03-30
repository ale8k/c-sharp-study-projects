using System;

namespace EventsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            VideoEncoder videoEncoder = new VideoEncoder();
            video.Title = "My video 1";

            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}
