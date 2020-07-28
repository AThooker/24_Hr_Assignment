using _24HourProject.Data;
using _24HourProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Services
{
    public class PostService
    {
        private readonly Guid _userId;

        public PostService(Guid userId)
        {
            _userId = userId;
        }
        public bool PostCreate(CreatePost model)
        {
            var entity =
                new Posting()
                {
                    OwnerId = _userId,
                    Title = model.Title,
                    Text = model.Text

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Postings.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }
        public IEnumerable<PostListItem> GetPosts()
        //this method will allow us to see all posts from a specific user
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Postings
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new PostListItem
                                {
                                    PostingId = e.PostingId,
                                    Title = e.Title,

                                }

                         );
                return query.ToArray();
            }
        }
    }
}
