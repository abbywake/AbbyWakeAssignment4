using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAssignment4.Models
{
    //class page so that happy customers can add resturaunts they like in provo too 
    public class addRes
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ResName { get; set; }

        [Required]
        public string FavDish { get; set; }
        [RegularExpression("[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]")]
        public string ResPhone { get; set; }
    }
}
