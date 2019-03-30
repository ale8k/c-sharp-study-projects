using System;
using System.Threading;

namespace EventsTutorial
{
    public class VideoEncoder
    {
        /* MAKING EVENTS:
         * Define our delegate
         * Define our event (based on our delegate)
         * Call our event in the method we want
         */

        // no idea why we send object:src, event args makes sense
        public delegate void VideoEncodedEventHandler(object src, EventArgs args); 
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
