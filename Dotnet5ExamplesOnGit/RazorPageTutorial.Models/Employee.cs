using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorPageTutorial.Models
{
   public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MinLength(3, ErrorMessage ="Name should contain at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a - z0 - 9][-a - z0 - 9._] +@([-a - z0 - 9] +[.]) +[a - z]{2, 5}$)", ErrorMessage ="Invalid email formate")]
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public Dept? Department { get; set; }
    }
}
