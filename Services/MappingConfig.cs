using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Social_Media_API.Models;
using Social_Media_API.Models.CommentModels;
using Social_Media_API.Models.PostModels;

namespace Social_Media_API.Services
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Post,PostDTO>().ReverseMap();

            CreateMap<Post,CreatePostDTO>().ReverseMap();

            CreateMap<Post,UpdatePostDTO>().ReverseMap();

            CreateMap<Comment,CommentDTO>().ReverseMap();
            CreateMap<Comment,CreateCommentDTO>().ReverseMap();
            CreateMap<Comment,UpdateCommentDTO>().ReverseMap();

        }
    }
}