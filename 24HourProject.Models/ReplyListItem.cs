using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    class ReplyListItem
    {
        public int CommentId { get; set; }
        public int PostingId { get; set; }
        public string ReplyComment { get; set; }
    }
}
