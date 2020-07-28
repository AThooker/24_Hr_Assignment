using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class CreatePost
    {
        //What data to we need to CAPTURE when a post is created?
        //no ID is needed here because .service and .data will take care of that.
        [Required]

        [MaxLength(200, ErrorMessage = "There are too many characters entered.")]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Text { get; set; }
    }
}
