using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAssignment4.Models
{
    public class addRes
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ResName { get; set; }

        [Required]
        public string FavDish { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public int ResPhone { get; set; }
    }
}
