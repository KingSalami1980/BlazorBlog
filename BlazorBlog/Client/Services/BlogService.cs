using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorBlog.Shared;

namespace BlazorBlog.Client.Services
{
    public class BlogService : IBlogService
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost {Url = "new-tutorial", Title = "A New Tutorial about Blazor", Description = "This is a new tutorial, showing you how to build a blog with Blazor", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim lobortis scelerisque fermentum dui faucibus in. Tempor nec feugiat nisl pretium fusce id. Erat velit scelerisque in dictum. Nam libero justo laoreet sit amet cursus sit. Eleifend quam adipiscing vitae proin sagittis. Lacinia at quis risus sed vulputate odio. Nulla facilisi nullam vehicula ipsum a arcu cursus. Et pharetra pharetra massa massa. Malesuada nunc vel risus commodo viverra maecenas. Libero nunc consequat interdum varius."},
            new BlogPost {Url = "first-post", Title = "My First Blog Post", Description = "Hi! This is my new shiny blog. Enjoy!", Content = "This is my beautiful short blog post. Isn't it nice?"}
        };

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }

        public BlogPost GetBlogPostByUrl(string url)
        {
            return Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
        }
    }
}
