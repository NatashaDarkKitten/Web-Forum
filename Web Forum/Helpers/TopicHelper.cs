using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Forum.Models;

namespace Web_Forum.Helpers
{
    public static class TopicHelper
    {

        public static MvcHtmlString CreateTopicDiv(this HtmlHelper html, Topic topic, User user)
        {
            TagBuilder mainDiv = new TagBuilder("div");

            TagBuilder title = new TagBuilder("h3");
            title.SetInnerText(topic.Subject);

            TagBuilder imageDiv = new TagBuilder("div");
            TagBuilder fontAwesomeImage = new TagBuilder("i");
            fontAwesomeImage.AddCssClass(user.FontAwesomeImage);
            imageDiv.InnerHtml += fontAwesomeImage;

            TagBuilder titleDiv = new TagBuilder("div");
            TagBuilder userProfile = new TagBuilder("a");
            userProfile.MergeAttribute("href", "Home/Profile/" + user.Id);
            userProfile.SetInnerText(user.Login);
            TagBuilder publicationDate = new TagBuilder("span");
            publicationDate.SetInnerText(topic.LastUpdate.ToString());
            TagBuilder subject = new TagBuilder("span");
            publicationDate.SetInnerText(topic.Subject.ToString());

            titleDiv.InnerHtml += userProfile;
            titleDiv.InnerHtml += publicationDate;
            titleDiv.InnerHtml += subject;

            TagBuilder contentDiv = new TagBuilder("div");
            contentDiv.InnerHtml += topic.Content;


            mainDiv.InnerHtml += imageDiv;
            mainDiv.InnerHtml += title;
            mainDiv.InnerHtml += contentDiv;

            return new MvcHtmlString(mainDiv.ToString());
        }

        public static MvcHtmlString CreateCommentSection(this HtmlHelper html, List<Comment> comments)
        {
            TagBuilder mainDiv = new TagBuilder("div");
            TagBuilder commentDiv = new TagBuilder("div");

            foreach (var comment in comments)
            {
                TagBuilder commentDate = new TagBuilder("p");
                commentDate.SetInnerText(comment.CreationDate.ToString());

                TagBuilder commentContent = new TagBuilder("p");
                commentDate.SetInnerText(comment.CreationDate.ToString());

                TagBuilder commentator = new TagBuilder("p");
                commentDate.SetInnerText(comment.User.ToString());

                commentDiv.InnerHtml += commentDate.ToString();
                commentDiv.InnerHtml += commentator.ToString();
                commentDiv.InnerHtml += commentContent.ToString();

                mainDiv.InnerHtml += commentDiv.ToString();
            }

            return new MvcHtmlString(mainDiv.ToString());
        }
    }
}