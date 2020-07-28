using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class PostListItem
    {
        //Handles the task of collecting property data for a list of notes
        //when a user enters info, we want them to enter specific data (posting.cs)
        //Ask: what specific data do we want to show in a specific view?
        public int PostingId { get; set; }
        public string Title { get; set; }
    }
}
