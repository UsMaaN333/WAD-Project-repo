using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WAD_SRMS_Project.models
{
    public class AddmissionModel
    {

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



        public string Email_ID { get; set; }

        [Required(ErrorMessage = ("No spaces or dashes"))]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
       ErrorMessage = "Entered phone format is not valid.")]
        [Column(TypeName = "varchar(12)")]
        public int MobileNumber { get; set; }

        public Gender Gender { get; set; }

        public DateTime Date_Of_birth { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public int Address { get; set; }

        [Required]

        [Column(TypeName = "varchar(30)")]
        public int City { get; set; }

        [Required]
        [Column(TypeName = "varchar(12)")]
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]

        public string State { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Country { get; set; }

        public Hobbies Hobbies { get; set; }

        public Qualification Qualification { get; set; }
        public CoursesAppliedFor CoursesAppliedFor { get; set; }

    }
    public enum Gender
    {
        Male, Female, None
    }
    public enum Hobbies
    {
        Drawing, Singing, Dancing, Sketching, Others

    }
    public enum Qualification
    {
        HighSchool10th, HigherSchool12th, GraduationBachelors, PostGraduationMasters, Phd
    }
    public enum CoursesAppliedFor
    {
        BCABachelorofComputerApplications, BComBachelorofCommerce, BScBachelorofScience
 , BABachelorofArts, MCMasterofComputerApplications, MComMasterofCommerc
 , MScMasterofScience, MAMasterofArts
    }
}

