using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Modelfeedback
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display (Name ="Email Address")]
        [Required]
        [EmailAddress (ErrorMessage ="The Email Address is Not valid")]
        public string MailId { get; set; }
        public string Country { get; set; }
        [Required(ErrorMessage ="Feedback can not be blank")]
        [DataType(DataType.MultilineText)]
        public string Feedback { get; set; }

    }
}
