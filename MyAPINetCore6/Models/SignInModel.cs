using System.ComponentModel.DataAnnotations;

namespace MyAPINetCore6.Models
{
    public class SignInModel
    {
        [Required]
        public string Mssv { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
