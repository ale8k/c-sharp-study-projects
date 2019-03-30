using System;

namespace EventsTutorial
{
    public class MailService
    {
        /*
         * Event handler method
         */
        public void OnVideoEncoded(object src, EventArgs args, string L)
        {
            Console.WriteLine("MailService: Sending mail..." + L);
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
