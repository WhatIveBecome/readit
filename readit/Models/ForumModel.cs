using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace readit.Models
{
    public class ForumModel
    {
        [Required]
        public int Id { get; set; }
        public int NumberOfTopics { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual IEnumerable<TopicModel> Topics { get; set; }

    }
}
