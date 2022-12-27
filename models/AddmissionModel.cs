using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WAD_SRMS_Project.models
{
    public class AddmissionModel
    {
        [Key]
        public string Email_Id { get; set; }

        [Required(ErrorMessage = "Please Enter Correct  First Name")]
        [Column(TypeName = "varchar(20)")]
        [RegularExpression("^[a-zA-Z]{2,12}$", ErrorMessage = "You must not enter integers")]
        [Display(Name = "First Name ")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Correct  First Name")]
        [Column(TypeName = "varchar(20)")]
        [RegularExpression("^[a-zA-Z]{2,12}$", ErrorMessage = "You must not enter integers")]
        [Display(Name = "First Name ")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage = ("No spaces or dashes"))]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
          ErrorMessage = "Entered phone format is not valid.")]
        [Column(TypeName = "varchar(12)")]
        public int Mobile_Number { get; set; }


    }
}
