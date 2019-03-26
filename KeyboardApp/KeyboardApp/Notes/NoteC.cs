using System;

namespace KeyboardApp.Notes
{
    class NoteC : INote
    {
        public string NoteType
        {
            get
            {
                return "Note C";
            }
        }

        public void Play()
        {
            Console.Beep(32000, 100000);
        }
    }
}
