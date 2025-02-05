using System.ComponentModel.DataAnnotations;

namespace DemoToTalSlide1To4.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email {  get; set; }
        [Required]
        [StringLength(100,MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Mat Khau khong khop")]
        public string ComfirmPassword {  get; set; }
        public string PhoneNumber {  get; set; }
    }
}
