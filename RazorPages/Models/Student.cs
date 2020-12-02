using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class Student
    {
        [Key] public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required] [Range(18, 30)] public int Age { get; set; }

        [Required, EnumDataType(typeof(GenderType))]
        public GenderType Gender { get; set; }
    }
}


