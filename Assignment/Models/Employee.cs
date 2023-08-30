using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Employee Id is Required")]
        public int EmployeeId { get; set; }



        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }



        [Required(ErrorMessage = "Last Name Is Required")]
        public string LastName { get; set; }



        [Remote(action: "IsEmailInUse",controller:"Employee")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Contact No is required.")]
        public string Phone { get; set; }



        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DatePastOnlyValidation(ErrorMessage ="Date Of Birth Must Be In Past.")]
        public DateTime DateOfBirth { get; set; }



        public string DeptName { get; set; }

        

    }
}
