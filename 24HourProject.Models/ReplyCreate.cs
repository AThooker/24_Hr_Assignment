using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    class ReplyCreate
    {
        // This is the Reply Create Model
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(2000, ErrorMessage = "There are too many characters in this field.")]
        public string ReplyComment { get; set; }
    }
}
