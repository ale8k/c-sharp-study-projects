using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack newStack = new Stack();

            newStack.Push(5);
            newStack.Push(44);
            newStack.Push(3);
            newStack.Push(2);
            newStack.Push(1);
            newStack.Pop();

            for (int i = 0; i < newStack.Length; i++)
            {
                Console.WriteLine(newStack[i]);
            }

            Console.ReadLine();
        }
    }
}
