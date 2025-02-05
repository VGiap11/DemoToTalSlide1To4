using System.ComponentModel.DataAnnotations;

namespace DemoToTalSlide1To4.Models.ViewModel
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
