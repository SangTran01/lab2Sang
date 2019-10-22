using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab1b.Data
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        //[Key]
        //[Display(Name = "User Name")]
        //public string UserName { get; set; }
        //[Required]
        //public string Email { get; set; }
        public string company { get; set; }
        public string Position { get; set; }
        [Required]
        [Display(Name = "Birth date")]
        public string BirthDate { get; set; }
    }
}
