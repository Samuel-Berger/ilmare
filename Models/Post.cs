namespace Ilmare
{
    public class Post
    {
        public int Id { get; }
        public string Title { get; }
        public string Url { get; }
        public string User { get; }
        public string Channel { get; }
        public string TimeCreated { get; }

        public Post(int id,
string title,
string url,
string user,
string channel,
string timeCreated)
{
        Id = id;
    Title = title;
    Url = url;
    User = user;
    Channel = channel;
    TimeCreated = timeCreated;
}
    }
}