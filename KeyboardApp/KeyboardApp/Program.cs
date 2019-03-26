using System;
using System.Collections.Generic;
using System.Linq;
using KeyboardApp.Notes;

namespace KeyboardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Composed myStuff = new Composed();
            myStuff.Add(new NoteA());
            myStuff.Add(new NoteB());
            myStuff.Add(new NoteA());
            myStuff.Add(new NoteC());
            myStuff.ViewNotes();
            Console.ReadLine();
        }
    }
}
