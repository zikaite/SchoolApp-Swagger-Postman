using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class School : Entity
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
