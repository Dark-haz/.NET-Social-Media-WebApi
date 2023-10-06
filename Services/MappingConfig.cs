using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Social_Media_API.Models;
using Social_Media_API.Models.DTO;

namespace Social_Media_API.Services
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Post,PostDTO>().ReverseMap();

            CreateMap<Post,CreatePostDTO>().ReverseMap();

            CreateMap<Post,UpdatePostDTO>().ReverseMap();
        }
    }
}