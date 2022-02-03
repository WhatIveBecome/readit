using System.ComponentModel.DataAnnotations;

namespace readit.Models
{
    public class ForumModel
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<GeneralModel> GeneralModel { get; set; } 
    }
}
