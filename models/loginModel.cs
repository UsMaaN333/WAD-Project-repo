using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WAD_SRMS_Project.models
{
    public class loginModel
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(15)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string? Email { get; set; }
        public int Password { get; set; }
    }
}
