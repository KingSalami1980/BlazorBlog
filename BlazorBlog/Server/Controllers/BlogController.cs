using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBlog.Shared;

namespace BlazorBlog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost {Url = "new-tutorial", Title = "A New Tutorial about Blazor with Web API", Description = "This is a new tutorial, showing you how to build a blog with Blazor", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim lobortis scelerisque fermentum dui faucibus in. Tempor nec feugiat nisl pretium fusce id. Erat velit scelerisque in dictum. Nam libero justo laoreet sit amet cursus sit. Eleifend quam adipiscing vitae proin sagittis. Lacinia at quis risus sed vulputate odio. Nulla facilisi nullam vehicula ipsum a arcu cursus. Et pharetra pharetra massa massa. Malesuada nunc vel risus commodo viverra maecenas. Libero nunc consequat interdum varius."},
            new BlogPost {Url = "first-post", Title = "My First Blog Post with Web API", Description = "Hi! This is my new shiny blog. Enjoy!", Content = "This is my beautiful short blog post. Isn't it nice?"}
        };

        [HttpGet]
        public ActionResult<List<BlogPost>> GimmeAllTheBlogPosts()
        {
            return Ok(Posts);
        }

        [HttpGet("{url}")]
        public ActionResult<BlogPost> GimmeThatSingleBlogPost(string url)
        {
            var post = Posts.FirstOrDefault(p => p.Url.ToLower() == url.ToLower());
            if (post == null)
            {
                return NotFound("This post does not exist.");
            }

            return Ok(post);
        }
    }
}
