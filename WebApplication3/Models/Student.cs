using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Student name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Student subject")]
        public string Subject { get; set; }
    }
}
