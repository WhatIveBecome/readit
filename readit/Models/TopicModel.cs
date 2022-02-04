using System.ComponentModel.DataAnnotations;

namespace readit.Models
{
    public class TopicModel
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int ForumModelId { get; set; }
        public virtual ForumModel ForumModel { get; set; } 
        //public IEnumerable<ReplyModel> Replies { get; set; }
        //public ReplyModel Reply { get; set; }
    }
}
