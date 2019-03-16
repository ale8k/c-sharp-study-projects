using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Design_a_StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Post fromChloe = new Post("Burgers");
            fromChloe.DislikePost();
            fromChloe.LikePost();
            fromChloe.LikePost();
            fromChloe.ReadPost();
            Console.ReadLine();

        }
    }
}
