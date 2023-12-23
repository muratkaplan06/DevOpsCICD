using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsCICD.Models;

namespace DevOpsCICD.Data
{
    public class PostRepository:IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel>
            {
                new PostViewModel()
                {
                    PostId = 1,
                    Title = "DevOps Title 1",
                    Description = "DevOps Description 1",
                    Author = "Ali"
                },
                new PostViewModel()
                {
                PostId = 2,
                Title = "DevOps Title 2",
                Description = "DevOps Description 2",
                Author = "Ayse"
                },new PostViewModel()
                {
                    PostId = 3,
                    Title = "DevOps Title 3",
                    Description = "DevOps Description 3",
                    Author = "Mehmet"
                }
            };
            return posts;
        }
    }
}
