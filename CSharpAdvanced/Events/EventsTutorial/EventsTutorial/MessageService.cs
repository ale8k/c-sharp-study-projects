using System;

namespace EventsTutorial
{
    public class MessageService
    {
        public void OnVideoEncoded(object src, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text..." + args.Video.Title);
        }
    }
}
