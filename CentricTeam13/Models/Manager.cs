using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CentricTeam13.Models
{
    public class Manager
    {
        public System.Guid managerId { get; set; }

        //public string firstName { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Manager First Name is Requried")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Manager Last Name is Requried")]
        [StringLength(20)]
        public string LastName { get; set; }


        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Manager is Requried")]
        [StringLength(100)]
        public string Email { get; set; }



        [Display(Name = "Moble Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) | \d{3}-)\d{3}-\d{4}$",
        ErrorMessage = "Student Cellphone MUST be in the format (xxx) xxx-xxxx")]
        public string Phone { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Department is Requried")]
        [StringLength(20)]
        public string Department { get; set; }

        public ICollection<FeedBack> feedBack { get; set; }

    }
}