using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using quiz_backend;
using quiz_backend.Models;
using Microsoft.AspNetCore.Authorization;

namespace quiz_backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Feed")]
    public class FeedController : Controller
    {
        private readonly QuizContext _context;

        public FeedController(QuizContext context)
        {
            _context = context;
        }


        [HttpGet("GetAllFeeds")]
        public IEnumerable<Feed> GetAllFeeds()
        {
            return _context.Feed;
        }

        [HttpPost("GetMyFeeds")]
        public IEnumerable<Feed> GetMyFeeds([FromBody] SimpleUser simpleUSer)
        {
            var myFeeds = _context.UserFeed.Where(e => e.UserId == simpleUSer.UserId).ToList();
            var allFeeds = _context.Feed.ToList();
            foreach (var feed in allFeeds)
            {
                if (myFeeds.Any(e => e.FeedId == feed.Id))
                {
                    feed.isSubscribed = true;
                }
            }
            return allFeeds;
        }


        [HttpPost("SubscribeUnsubscribe")]
        public bool SubscribeUnsubscribe([FromBody] UserFeed uf)
        {
            var relationship = _context.UserFeed.SingleOrDefault(m => m.UserId == uf.UserId && m.FeedId == uf.FeedId);
            if (relationship == null)
            {
                _context.UserFeed.Add(new UserFeed { FeedId = uf.FeedId, UserId = uf.UserId });
            }
            else
            {
                _context.UserFeed.Remove(relationship);

            }
            _context.SaveChanges();
            return true;
        }


    }
}