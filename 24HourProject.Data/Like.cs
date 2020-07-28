using _24HourProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class Like
    {   
        [Key]
        public int LikeId { get; set; }
        [Required]
        public int PostingId { get; set; }
        [ForeignKey(nameof(PostingId))]
        public virtual Posting Posting { get; set; }

        [Required]
        public Guid OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public virtual User Liker { get; set; }
    }
}
