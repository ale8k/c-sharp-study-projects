using System;

namespace Design_a_StackOverflow_Post
{
    public class Post
    {

        private string _postTitle;
        private string _postDesc;
        private readonly DateTime _createdAt;
        public int VoteValue { get; private set; }

        private Post()
        {
            _createdAt = DateTime.Now;
        }

        public Post(string title) : this()
        {
            _postTitle = title;
            _postDesc = "No content provided";  
        }

        public Post(string title, string description) : this(title)
        {
            _postDesc = description;
        }

        public void UpdateTitle(string newTitle)
        {
            _postTitle = newTitle;
        }

        public void UpdateDesc(string newDesc)
        {
            _postDesc = newDesc;
        }

        public void LikePost()
        {
            VoteValue += 1;
        }

        public void DislikePost()
        {
            VoteValue -= 1;
        }

        public void ReadPost()
        {
            Console.WriteLine(_postTitle);
            Console.WriteLine(_postDesc);
            Console.WriteLine($"Created at: {_createdAt} and has {VoteValue} votes");
        }

    }
}
