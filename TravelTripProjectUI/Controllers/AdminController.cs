using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectUI.Models.Classes;
using TravelTripProjectUI.Models.Classes.Contexts;

namespace TravelTripProjectUI.Controllers
{
    public class AdminController : Controller
    {

        // BLOG
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("EditBlog", blog);
        }

        [HttpPost]
        public ActionResult EditBlog(Blog b)
        {
            var blog = c.Blogs.Find(b.ID);
            blog.Description = b.Description;
            blog.Heading = b.Heading;
            blog.BlogImage = b.BlogImage;
            blog.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        // COMMENTS
        public ActionResult CommentList()
        {
            var comments = c.Comments.ToList();
            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var com = c.Comments.Find(id);
            c.Comments.Remove(com);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

        [HttpGet]
        public ActionResult EditComment(int id)
        {
            var comment = c.Comments.Find(id);
            return View("EditComment", comment);
        }

        [HttpPost]
        public ActionResult EditComment(Comment comment)
        {
            var cm = c.Comments.Find(comment.ID);
            cm.UserName = comment.UserName;
            cm.Mail = comment.Mail;
            cm.Commentss = comment.Commentss;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public ActionResult About()
        {
            var about = c.Abouts.ToList();
            return View(about);
        }

        [HttpGet]
        public ActionResult EditAbout(int id)
        {
            var about = c.Abouts.Find(id);
            return View("EditAbout", about);
        }

        [HttpPost]
        public ActionResult EditAbout(About b)
        {
            var about = c.Abouts.Find(b.ID);
            about.Description = b.Description;
            about.PhotoUrl = b.PhotoUrl;
            c.SaveChanges();
            return RedirectToAction("About");
        }
    }
}