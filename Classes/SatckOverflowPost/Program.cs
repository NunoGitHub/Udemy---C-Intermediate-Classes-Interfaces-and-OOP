namespace StackOverflowPost
{
    class Program
    {
        public static void Main(string[] args)
        {
            StackOverflowPost post = new StackOverflowPost("title", "a post");
            post.DownVote();
            Console.WriteLine($"{post.title} {post.description} {post.Vote}");
            post.UpVote();
            Console.WriteLine($"{post.title} {post.description} {post.Vote}");

        }
    }
}