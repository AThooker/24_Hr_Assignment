using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class ReplyCreate
    {
        // This is the Reply Create Model
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(2000, ErrorMessage = "There are too many characters in this field.")]
        //public Comment ReplyComment { get; set; }
        public string Text { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        public int PostingId { get; set; }
    }
}
