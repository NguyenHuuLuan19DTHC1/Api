using System.ComponentModel.DataAnnotations;

namespace MyAPINetCore6.Models
{
    public class SignUpModel
    {
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string Mssv { get; set; }=null!;
        [Required]
        public string Password { get; set; }=null!;
        [Required]
        public string ConfirmPassword { get; set; } = null!;

    }
}
