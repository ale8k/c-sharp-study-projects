using System;

namespace KeyboardApp.Notes
{
    class NoteB : INote
    {
        public string NoteType
        {
            get
            {
                return "Note B";
            }
        }

        public void Play()
        {
            Console.Beep(2000, 1000);
        }
    }
}
