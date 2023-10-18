using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Social_Media_API.Models;
using Social_Media_API.Models.CommentModels;
using Social_Media_API.Services.Repository;
using Social_Media_API.Services.Repository.IRepository;

namespace Social_Media_API.Controllers.v2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/CommentAPI")]
    [ApiVersion("2.0")]
    public class CommentAPIController : ControllerBase
    {

        private readonly ICommentRepository _dbComment;
        private readonly IPostRepository _dbPost; //! Foreign key table
        private readonly IMapper _mapper;
        protected APIResponse _response;


        public CommentAPIController(ICommentRepository dbComment, IPostRepository dbPost, IMapper mapper)
        {
            _dbComment = dbComment;
            _dbPost = dbPost;
            _mapper = mapper;
            this._response = new();
        }


        //> GET ALL |-----------------------------------

        [HttpGet]
        public string Get()
        {
            return "hello world";
        }

    }
}