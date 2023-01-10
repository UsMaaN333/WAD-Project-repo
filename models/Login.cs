using System.ComponentModel.DataAnnotations;

namespace WAD_SRMS_Project.models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]

        public string Repeat_Password { get; set; }
    }
}
