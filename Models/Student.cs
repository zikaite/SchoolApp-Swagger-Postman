using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class Student : Entity
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public string Sex { get; set; }
        public int SchoolId { get; set; }
    }
}
