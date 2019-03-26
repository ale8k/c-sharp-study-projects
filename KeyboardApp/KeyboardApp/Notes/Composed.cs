using System;
using System.Collections.Generic;

namespace KeyboardApp.Notes
{
    public class Composed
    {
        private readonly List<INote> _notes;

        public Composed()
        {
            _notes = new List<INote>();
        }

        public void Add(INote note)
        {
            _notes.Add(note);
        }

        public void Remove(int i)
        {
            _notes.RemoveAt(i);
        }

        public void ViewNotes()
        {
            foreach (INote note in _notes)
            {
                Console.WriteLine($"{ note.NoteType} is at index: {_notes.IndexOf(note)}");
                note.Play();
            }
        }
    }
}
