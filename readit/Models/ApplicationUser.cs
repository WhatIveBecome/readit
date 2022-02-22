using Microsoft.AspNetCore.Identity;

namespace readit.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nick { get; set; }
    }
}
