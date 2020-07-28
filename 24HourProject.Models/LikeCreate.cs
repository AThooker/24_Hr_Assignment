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
    public class LikeCreate
    {
        [Key]
        public int LikeId { get; set; }
        [Required]
        public int PostingId { get; set; }
    }
}
