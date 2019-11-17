using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3.Models
{
    public class Test
    {
        [Required]
        [StringLength(20,MinimumLength =2,ErrorMessage = "Name must be between 2 to 20")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Last must be between 2 to 20")]
        public string LastName { get; set; }
        [RegularExpression("^[0][5][0-4][(0-9)*]{10}$")]
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}