using System.ComponentModel.DataAnnotations;

namespace readit.Models
{
    public class ReplyModel
    {
        [Required]
        public int Id { get; set; }
        [StringLength(4000, MinimumLength = 1)]
        public string Description { get; set; }
        public int TopicModelId { get; set; }
        public virtual TopicModel TopicModel { get; set; }
    }
}
