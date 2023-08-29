using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
         
        public int EmployeeId { get; set; }
     
        public string FirstName { get; set; }
      
        public string LastName { get; set; }

        [Remote(action: "IsEmailInUse",controller:"Employee")]
        public string Email { get; set; }
      
        public string Phone { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string DeptName { get; set; }

        

    }
}
