using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Forum.Models;
using System.IO;
using System.Data.Entity;

namespace Web_Forum.Controllers
{
    public class HomeController : Controller
    {
        ForumContext db = new ForumContext();

        // TODO: ounput topics
        // TODO: filter topics
        public ActionResult Index()
        {
            var topics = db.Topics;
            return View(topics.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        // TODO: button Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        // TODO: form login
        [HttpPost]
        public void Login(User user)
        {
            //db.Users.Find("Login", user.Login);
        }

        // TODO: button Signup
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        // TODO: form Signup
        [HttpPost]
        public void Signup(User user)
        {
            //db.Users.Find("Login", user.Login);
        }
        private void AddUser(User user)
        {
            //user.RegistrationDate = DateTime.Now;
            //db.Users.Add(user);
            //db.SaveChanges();
        }
        
        [HttpGet]
        public ActionResult Topic(Guid? id)
        {//.Where(t => t.Id.Equals(id)).Include(t => t.User).Include(t => t.Comments)
            if (id == null)
            {
                return HttpNotFound();
            }
            var topic = db.Topics.FirstOrDefault(t => t.Id == id);

            if (topic != null)
            {
                return View(topic);
            }
            return HttpNotFound();
        }

        // TODO: ancor topic
        [HttpPost]
        public void AddTopic(Topic topic)
        {
            //topic.CreationDate = DateTime.Now;
            //db.Topics.Add(topic);
            //db.SaveChanges();
        }



        [HttpGet]
        public ViewResult Account()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Account(User user)
        {
            return View("Index");
        }

        [HttpGet]
        public ActionResult UserProfile(string login)
        {
            if (login == null)
            {
                return HttpNotFound();
            }
            var user = db.Users.FirstOrDefault(u => u.Login.Equals(login));
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }


        [HttpGet]
        public void AddToFavorites(int? topicId)
        {
            //user.RegistrationDate = DateTime.Now;
            //db.Users.Add(user);
            db.SaveChanges();
        }

        [HttpGet]
        public void AddToLikes(int? topicId)
        {
            //user.RegistrationDate = DateTime.Now;
            //db.Users.Add(user);
            db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}