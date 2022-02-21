using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace readit.Models
{
    public class ForumModel
    {
        [Required]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 2)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual IEnumerable<TopicModel> Topics { get; set; }
        //public virtual IEnumerable<TopicListingModel> TopicListing { get; set; }
    }
}
