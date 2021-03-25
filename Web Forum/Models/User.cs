using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Forum.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Role { get; set; }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string FontAwesomeImage { get; set; }

        public bool isActive { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Topic> Favorites { get; set; }

        public virtual ICollection<Topic> Likes { get; set; }

        public virtual ICollection<Topic> Views { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }

        public User()
        {
            this.Id = Guid.NewGuid();
        }

        public User(string role, string login, string name, string surname, string email, string fontAwesomeImage)
        {
            this.Id = Guid.NewGuid();
            this.Role = role;
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.RegistrationDate = DateTime.Now;
            this.FontAwesomeImage = "fas fa-user";
            // TODO: temp, change on false
            this.isActive = true;
            this.Topics = new List<Topic>();
            this.Comments = new List<Comment>();
            this.Favorites = new List<Topic>();
            this.Likes = new List<Topic>();
            this.Views = new List<Topic>();
            this.Sessions = new List<Session>();
        }
    }

    public class Session
    {
        public Guid Id { get; set; }

        public string Browser { get; set; }

        public string UserAgent { get; set; }

        public string UserHostAddress { get; set; }

        public string Cookies { get; set; }

        public DateTime EntryDate { get; set; }

        public Session(string browser, string userAgent, string userHostAddress, string cookies)
        {
            this.Id = new Guid();
            this.Browser = browser;
            this.UserAgent = userAgent;
            this.UserHostAddress = userHostAddress;
            this.Cookies = cookies;
        }
    }
}