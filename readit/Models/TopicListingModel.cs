namespace readit.Models
{
    public class TopicListingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ForumModelId { get; set; }
        //public virtual ForumModel ForumModel { get; set; }
        //public virtual IEnumerable<ReplyModel> Replies { get; set; }
        public int NumberOfReplies { get; set; }
    }
}
