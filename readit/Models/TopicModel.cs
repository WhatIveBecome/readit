using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public virtual IEnumerable<ReplyModel> Replies { get; set; }


    }
}
