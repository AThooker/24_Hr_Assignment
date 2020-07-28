using _24HourProject.Models;
using _24HourProject.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _24_Hour_Project.Controllers
{
    public class LikeController : ApiController
    {
        //Get Likes
        public IHttpActionResult GetLikes()
        {
            LikeService likeService = CreateLikeService();
            var likes = likeService.GetLikes();
            return Ok(likes);
        }
        //Post Like
        public IHttpActionResult PostLike(LikeCreate like)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLikeService();

            if (!service.CreateLike(like))
                return InternalServerError();

            return Ok();
        }
        private LikeService CreateLikeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var likeService = new LikeService(userId);
            return likeService;
        }
        //Delete
        public IHttpActionResult DeleteLike(int id)
        {
            var service = CreateLikeService();
            if (!service.DeleteLike(id))
                return InternalServerError();
            return Ok();
        }
    }
}