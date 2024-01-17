namespace Model
{
    public class Tweet
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Tweetcontext { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
    }
}