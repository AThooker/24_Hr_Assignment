using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class ReplyDetail
    {
        [Display(Name = "Comment ID")]
        public int CommentId { get; set; }
        [Display(Name = "Posted ID")]
        public int PostingId { get; set; }

        [Display(Name = "Reply")]
        public string ReplyComment { get; set; }
    }
}
