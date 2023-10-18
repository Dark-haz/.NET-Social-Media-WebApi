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

namespace Social_Media_API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/CommentAPI")]
    [ApiVersion("1.0")]
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
        // [Authorize(Roles ="Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetComments() 
        {
            try
            {

                IEnumerable<Comment> commentList = await _dbComment.GetAllAsync(null,"Post");
                _response.Result = _mapper.Map<List<CommentDTO>>(commentList);
                _response.StatusCode = HttpStatusCode.OK;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        //> GET ONE |-----------------------------------

        [HttpGet("{id:int}", Name = "GetComment")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> Getcomment(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var comment = await _dbComment.GetAsync(e => e.Id == id,true,"Post");

                if (comment == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSucess = false;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<CommentDTO>(comment);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        //> CREATE |-----------------------------------

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<APIResponse>> Createcomment([FromBody] CreateCommentDTO createDTO)
        {

            try
            {
                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }

                //! CHECK IF FOREIGN ID EXISTS
                if (await _dbPost.GetAsync(e => e.Id == createDTO.PostID) == null)
                {
                    ModelState.AddModelError("CustomError", "Post ID is Invalid!");
                    return BadRequest(ModelState);
                }

                Comment comment = _mapper.Map<Comment>(createDTO);

                await _dbComment.CreateAsync(comment);

                _response.Result = _mapper.Map<CommentDTO>(comment);
                _response.StatusCode = HttpStatusCode.OK;

                return CreatedAtRoute("GetComment", new { id = comment.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }


        //> DELETE |-----------------------------------

        [HttpDelete("{id:int}", Name = "DeleteComment")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> Deletecomment(int id)
        {
            try
            {
                if (id == 0) { return BadRequest(); }

                var comment = await _dbComment.GetAsync(e => e.Id == id);
                if (comment == null)
                {
                    return NotFound();
                }

                await _dbComment.RemoveAsync(comment);

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        //>  PUT|-----------------------------------

        [HttpPut("{id:int}", Name = "UpdateComment")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> Updatecomment(int id, [FromBody] UpdateCommentDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.Id)
                {
                    return BadRequest();
                }

                //! CHECK IF FOREIGN ID EXISTS
                if (await _dbPost.GetAsync(e => e.Id == updateDTO.PostID) == null)
                {
                    ModelState.AddModelError("CustomError", "Post ID is Invalid!");
                    return BadRequest(ModelState);
                }

                Comment model = _mapper.Map<Comment>(updateDTO);
                await _dbComment.UpdateAsync(model);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSucess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;

        }

    }
}