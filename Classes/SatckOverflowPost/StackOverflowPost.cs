namespace StackOverflowPost
{
    public class StackOverflowPost
    {
        public readonly string title;
        public readonly string description;
        public readonly DateTime date;
        public int Vote { get; private set; }

        public StackOverflowPost(string title, string description)
        {
            if ((title == null || title?.Trim() == "") || (description == null  || description?.Trim() == "")) throw new ArgumentException("Title and description maybe null or empty string ");
            this.title = title;
            this.description = description;
            this.date = DateTime.Now;
            this.Vote = 0;

        }

        public void DownVote()
        {
            Vote--;
        }
            
        public void UpVote()
        {
            Vote++;
        }

    }
}