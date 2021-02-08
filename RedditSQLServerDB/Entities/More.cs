namespace RedditSQLServerDB.Entities
{
    public class More
    {
        public string Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public int Depth { get; set; }
    }
}
