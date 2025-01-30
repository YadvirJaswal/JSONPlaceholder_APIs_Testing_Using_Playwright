using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_API_Testing_Using_Playwright.Models
{
    public class PostsModel
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }
}
