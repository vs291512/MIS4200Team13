using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CentricTeam13.Models
{
    public class FeedBack
    {
        public System.Guid feedBackId { get; set; }

        //public string firstName { get; set; }
        [Display(Name = "Feedback")]
        [Required(ErrorMessage = "FeedBack is Requried")]
        [StringLength(20)]
        public string feedBack { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Manager Manager { get; set; }
    }
}