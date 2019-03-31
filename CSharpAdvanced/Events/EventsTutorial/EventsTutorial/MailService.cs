using System;

namespace EventsTutorial
{
    public class MailService
    {
        /*
         * Event handler method
         */
        public void OnVideoEncoded(object src, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending mail..." + args.Video.Title);
        }

        // delegate reminder stuff, ignore if thinking about events
        public string ChatFirst(string i)
        {
            Console.WriteLine(i);
            return i;
        }
        public string ChatSecond(string i)
        {
            Console.WriteLine(i);
            return i;
        }
    }
}
