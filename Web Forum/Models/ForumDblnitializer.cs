using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web_Forum.Models
{
    public class ForumDblnitializer : DropCreateDatabaseAlways<ForumContext>
    {
        protected override void Seed(ForumContext db)
        {
            var kit = new User("admin", "dark_kitten", "Kitten", "Dark", "nsavelenko@gmail.com", "fas fa-cat");
            var tomGuid = new User("moderator", "tom", "Tomas", "Edilum", "tomas@gmail.com", "fas fa-dragon");
            var ritaGuid = new User("user", "rita", "Margaret", "Stark", "rita2000@gmail.com", "fas fa-crow");


            db.Users.Add(kit);
            db.Users.Add(tomGuid);
            db.Users.Add(ritaGuid);


            db.Topics.Add(new Topic(kit, "Test Subject", "First topic", "Етикетне правило щодо цифрової комунікації передбачає, що вона є асинхронною за замовчуванням і синхронною за потребою."));
            db.Topics.Add(new Topic(tomGuid, "Theme", "sECOND topic", "The etiquette rule for digital communication assumes that it is asynchronous by default and synchronous as needed."));
            db.Topics.Add(new Topic(tomGuid, "adglkma;dfmgk", "dgakfmdg;lsfd,g", "ddddddddddddddddddddddddddddddddddddddddddd"));

            base.Seed(db);
            
        }
    }
}