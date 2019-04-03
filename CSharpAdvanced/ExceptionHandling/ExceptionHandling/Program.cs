using System;
using System.Net;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /*
             * Async / await tests
             */
            Program lol = new Program();
            Task<string> shittolog = lol.Download("https://msdn.microsoft.com");
            Console.WriteLine("waiting for async task");
            Console.WriteLine(shittolog.Result);
            Console.ReadLine();
        }


        public async Task<string> Download(string url)
        {
            WebClient webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
