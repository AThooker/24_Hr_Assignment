using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    class LikeListItem
    {
        public int LikeId { get; set; }
        public int PostingId { get; set; }
        public Guid OwnerId { get; set; }
    }
}
