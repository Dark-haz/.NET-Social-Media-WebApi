using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Social_Media_API.Models.DTO;

namespace Social_Media_API.Data
{
    //! Temporary data storage
    public static class PostStore
    {
        public static List<PostDTO> postList = new List<PostDTO> {
            new PostDTO{Id=1,Title="Hello world"},
            new PostDTO{Id=2,Title="Help writing essay"}
        };
    }
}