using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsCICD.Models;

namespace DevOpsCICD.Data
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
