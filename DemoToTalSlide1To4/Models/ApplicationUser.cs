using Microsoft.AspNetCore.Identity;

namespace DemoToTalSlide1To4.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
