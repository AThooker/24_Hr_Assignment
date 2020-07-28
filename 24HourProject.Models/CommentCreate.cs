using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class CommentCreate
    { 
        //what we want to take in to create a comment
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least 1 character")]
        [MaxLength(1000, ErrorMessage = "You have entered too many characters")]
        public string Text { get; set; }
    }
}
