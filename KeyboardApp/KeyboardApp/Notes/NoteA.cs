using System;

namespace KeyboardApp.Notes
{
    public class NoteA : INote
    {
        public string NoteType
        {
            get
            {
                return "Note A";
            }
        }

        public void Play()
        {
            Console.Beep(1000, 1000);
        }
    }
}
