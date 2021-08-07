using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectUI.Models.Classes;
using TravelTripProjectUI.Models.Classes.Contexts;

namespace TravelTripProjectUI.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComment blogComment = new BlogComment();

        [AllowAnonymous]
        public ActionResult Index()
        {
            //var values = c.Blogs.ToList();
            blogComment.Blog = c.Blogs.ToList();
            return View(blogComment);
        }

        [AllowAnonymous]
        public ActionResult BlogDetail(int id)
        {
            //var findBlog = c.Blogs.Where(x => x.ID == id).ToList();
            blogComment.Blog = c.Blogs.Where(x => x.ID == id).ToList();
            blogComment.Comments = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(blogComment);
        }

        [AllowAnonymous]
        public PartialViewResult BlogMenu()
        {
            blogComment.Blog2 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(blogComment);
        }

        [HttpGet]
        [AllowAnonymous]
        public PartialViewResult CommentAdd(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }

        [HttpPost]
        [AllowAnonymous]
        public PartialViewResult CommentAdd(Comment cm)
        {
            c.Comments.Add(cm);
            c.SaveChanges();
            return PartialView();
        }
    }
}