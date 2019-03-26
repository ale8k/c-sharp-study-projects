namespace KeyboardApp.Notes
{
    public interface INote
    {
        string NoteType { get; }
        void Play();
    }
}
