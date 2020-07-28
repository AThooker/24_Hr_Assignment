﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class CommentListItem
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        [Display(Name = "Comment submitted")]
        public DateTimeOffset CreatedUtc { get; set; }
        public Guid OwnerId { get; set; }
    }
}
