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
                },
                 new ForumModel
                 {
                     Id = 2,
                     Name = "C",
                     Description = "Forum inteded for the C programming language",
                 },
                  new ForumModel
                  {
                      Id = 3,
                      Name = "C++",
                      Description = "Forum inteded for the C++ programming language",
                  },
                   new ForumModel
                   {
                       Id = 4,
                       Name = "C#",
                       Description = "Forum inteded for the C# programming language",
                   },
                    new ForumModel
                    {
                        Id = 5,
                        Name = "HTML",
                        Description = "Forum inteded for the HyperText Markup Language",
                    },
                     new ForumModel
                     {
                         Id = 6,
                         Name = "CSS",
                         Description = "Forum inteded for the Cascading Style Sheets",
                     },
                      new ForumModel
                      {
                          Id = 7,
                          Name = "JS",
                          Description = "Forum inteded for the JavaScript programming language",
                      }
                );
        }
    }
}
