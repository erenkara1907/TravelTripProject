using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProjectUI.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> Blog { get; set; }
        public IEnumerable<Blog> Blog2 { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}