using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CentricTeam13.Models
{
    public class Employee
    {
        public System.Guid employeeId { get; set; }

        //public string firstName { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Employee First Name is Requried")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Employee Last Name is Requried")]
        [StringLength(20)]
        public string LastName { get; set; }


        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Employee is Requried")]
        [StringLength(100)]
        public string Email { get; set; }



        [Display(Name = "Moble Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) | \d{3}-)\d{3}-\d{4}$",
        ErrorMessage = "Employee Cellphone MUST be in the format (xxx) xxx-xxxx")]
        public string Phone { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Department is Requried")]
        [StringLength(20)]
        public string Department { get; set; }
        public ICollection<FeedBack> feedBack { get; set; }

    }
}