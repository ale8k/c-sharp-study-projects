using System;
using System.Threading;

namespace EventsTutorial
{
    public class VideoEncoder
    {
        /* 
         * MAKING EVENTS:
         * Define our delegate
         * Define our event (based on our delegate)
         * Call our event in the method we want
         */

        // no idea why we send object:src, event args makes sense
        //public delegate void VideoEncodedEventHandler(object src, VideoEventArgs args, string L); 
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded; // e. param?
        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            
        }
    }
}
