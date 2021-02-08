using System;
using System.Collections.Generic;

namespace RedditSQLServerDB.Entities
{
    public class Comment
    {
        public string Id { get; set; }
        public string SubredditId { get; set; }
        public string Subreddit { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public string BodyHTML { get; set; }
        public bool Collapsed { get; set; }
        public string CollapsedReason { get; set; }
        public bool IsSubmitter { get; set; }
        public List<Comment> Replies { get; set; }
        public List<More> More { get; set; }
        public bool ScoreHidden { get; set; }
        public int Depth { get; set; }
        public string AuthorFullname { get; set; }
        public string Permalink { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public int Score { get; set; }
        public int Ups { get; set; }
        public int Downs { get; set; }
        public bool Removed { get; set; }
        public bool Spam { get; set; }
        public string Name { get; set; }
        public bool? Likes { get; set; }
    }
}
