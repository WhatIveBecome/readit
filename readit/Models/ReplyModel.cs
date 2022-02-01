using System.ComponentModel.DataAnnotations;

namespace readit.Models
{
    public class ReplyModel
    {
        [Required]
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<ReplyModel> Replies { get; set; }          
    }
}
