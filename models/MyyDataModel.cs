using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WAD_SRMS_Project.models
{
    public class MyyDataModel
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter Correct  First Name")]
        [Column(TypeName = "varchar(20)")]
        [RegularExpression("^[a-zA-Z]{2,12}$", ErrorMessage = "You must not enter integers")]
        [Display(Name = "First Name ")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Correct  Last Name")]

        [Column(TypeName = "varchar(20)")]
        [RegularExpression("^[a-zA-Z]{2,12}$", ErrorMessage = "You must not enter integers")]
        [Display(Name = "Last Name ")]
        public string Last_Name { get; set; }



        public DateTime Date_Of_birth { get; set; }



        public gender Gender { get; set; }



        [Required]
        [Column(TypeName = "varchar(20)")]
        [DataType(DataType.Password)]
        public int Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The Password does not match")]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Re-Type Password")]

        [DataType(DataType.Password)]
        public int ReTypePassword { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Security Question")]
        public Questions SecurityQuestion { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Security Answer")]
        public string SecurityAnswer { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(12)")]
        [RegularExpression("^[a-zA-Z]{2,12}$", ErrorMessage = "You must not enter integers")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "varchar(8)")]
        public state State { get; set; }

        [Display(Name = "Zip Code ")]
        [Column(TypeName = "varchar(12)")]
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = ("No spaces or dashes"))]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
          ErrorMessage = "Entered phone format is not valid.")]
        [Column(TypeName = "varchar(12)")]
        public int Phone { get; set; }



    }
    public enum gender
    {
        Male, Female, None
    }
    public enum Questions
    {
        Questions1, Questions2, Questions3, Questions4, Questions5, Questions6, Questions7, Questions8
    }
    public enum state
    {
        State1, State2, State3, State4, State5, State6, State7, State8
    }
}

