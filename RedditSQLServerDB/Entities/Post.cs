using System;

namespace RedditSQLServerDB.Entities
{
    public class Post
    {
        public string Id { get; set; }
        public string SubredditId { get; set; }
        public string Subreddit { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Downs { get; set; }
        public string Name { get; set; }
        public double UpvoteRatio { get; set; }
        public int Ups { get; set; }
        public string Domain { get; set; }
        public string AuthorFullname { get; set; }
        public string Category { get; set; }
        public int NumComments { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public int Score { get; set; }
        public bool? Likes { get; set; }
        public int? ViewCount { get; set; }
        public bool Archived { get; set; }
    }
}
