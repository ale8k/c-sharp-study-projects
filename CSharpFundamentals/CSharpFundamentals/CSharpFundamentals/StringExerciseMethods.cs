using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFundamentals
{
    class StringExerciseMethods
    {

        // needs putting into methods bruv.


        //string userInput = Console.ReadLine();
        //string[] h = userInput.Split('-');
        //List<int> myList = new List<int>();

        //foreach (string s in h)
        //{
        //    myList.Add(Convert.ToInt32(s));
        //}
        //bool consP = true;


        //for (int i = 0; i < myList.Count - 1; i++)
        //{
        //    if (myList[i] + 1 == myList[i + 1] || myList[i] - 1 == myList[i + 1])
        //    {
        //        continue;
        //    }
        //    else
        //    {
        //        consP = false;
        //    }
        //}

        //if (consP == false)
        //{
        //    Console.WriteLine("not cons p");
        //}
        //else
        //{
        //    Console.WriteLine("cons p");
        //}

        // challenge 2

        //string userInput = Console.ReadLine();

        //if(String.IsNullOrWhiteSpace(userInput) == true || String.IsNullOrEmpty(userInput) == true)
        //{
        //    Environment.Exit(0);
        //}
        //else
        //{
        //    string[] splitup = userInput.Split('-');

        //    IEnumerable<string> distinctive = splitup.Distinct();
        //    string[] splitupd = distinctive.ToArray();

        //    string X = string.Join("", splitup);
        //    string x = string.Join("", distinctive);

        //    if (x == X)
        //    { Console.WriteLine("idkc"); }
        //}
        //Console.ReadLine();

        // challenge 3

        //Console.WriteLine("enter a time value in the 24-hour time format, i.e. 19:00");
        //Console.WriteLine("valid is from 00:00 to 23:59, if u enter wrong it is invalid");

        //string userInput = Console.ReadLine();

        //try
        //{
        //    DateTime.Parse(userInput);
        //    Console.WriteLine("Successful");
        //}
        //// would catching all exceptions be better than catching the specific one for this...?
        //catch (Exception)
        //{
        //    Console.WriteLine("Invalid format");
        //}
        //Console.ReadLine();

        // challenge 4

        //string userInput = Console.ReadLine().ToLower();
        //string[] splitStr = userInput.Split(' ');
        //List<string> final = new List<string>();

        //foreach (string s in splitStr)
        //{
        //    char[] n = s.ToCharArray(); 
        //    string firstL = n[0].ToString().ToUpper(); 
        //    n[0] = Convert.ToChar(firstL); 
        //    string complete = String.Join("", n);
        //    final.Add(complete);
        //}
        //string newString = string.Join("", final);
        //Console.WriteLine(newString);
        //Console.ReadLine();

        // challenge 5

        // checked answer - i would've done same or done a huge if / switch lol.
    }
}
