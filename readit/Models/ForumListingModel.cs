using System.ComponentModel.DataAnnotations;

namespace readit.Models
{
    public class ForumListingModel
    {
        public int Id { get; set; }
        public int NumberOfTopics { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
