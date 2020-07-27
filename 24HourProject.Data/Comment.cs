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
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public int PostingId { get; set; }
        [ForeignKey(nameof(PostingId))]
        public virtual Posting Posting { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey(nameof(Name))]
        public virtual User Author { get; set; }
    }
}
