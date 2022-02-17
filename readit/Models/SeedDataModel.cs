using Microsoft.EntityFrameworkCore;

namespace readit.Models
{
    public static class SeedDataModel
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var forumModel = new ForumModel();

            modelBuilder.Entity<ForumModel>().HasData(
                new ForumModel
                {
                    Id = 1,
                    Name = "General discussion",
                    Description = "Basic informations",
                    NumberOfTopics = forumModel.Topics?.Count() ?? 0,
                    ImageUrl = "/images/i2.png",
                },
                 new ForumModel
                 {
                     Id = 2,
                     Name = "C",
                     Description = "Forum inteded for the C programming language",
                     ImageUrl = "/images/c.png",
                 },
                  new ForumModel
                  {
                      Id = 3,
                      Name = "C++",
                      Description = "Forum inteded for the C++ programming language",
                      ImageUrl = "/images/c2.png",
                  },
                   new ForumModel
                   {
                       Id = 4,
                       Name = "C#",
                       Description = "Forum inteded for the C# programming language",
                       ImageUrl = "/images/c3.png",
                   },
                    new ForumModel
                    {
                        Id = 5,
                        Name = "HTML",
                        Description = "Forum inteded for the HyperText Markup Language",
                        ImageUrl = "/images/html.png",
                    },
                     new ForumModel
                     {
                         Id = 6,
                         Name = "CSS",
                         Description = "Forum inteded for the Cascading Style Sheets",
                         ImageUrl = "/images/css.png",
                     },
                      new ForumModel
                      {
                          Id = 7,
                          Name = "JS",
                          Description = "Forum inteded for the JavaScript programming language",
                          ImageUrl = "/images/js.png",
                      }
                );
        }
    }
}
