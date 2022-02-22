using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace readit.Models
{
    public class TopicModel
    {
        [Required]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        [StringLength(4000, MinimumLength = 2)]
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public string Author { get; set; }
        [Required]     
        public int ForumModelId { get; set; }
        public virtual ForumModel ForumModel { get; set; }
        public virtual IEnumerable<ReplyModel> Replies { get; set; }
    }
}
