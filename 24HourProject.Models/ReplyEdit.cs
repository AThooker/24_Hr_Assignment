using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    class ReplyEdit
    {
        [Display(Name = "Reply")]
        public string ReplyComment { get; set; }
    }
}
