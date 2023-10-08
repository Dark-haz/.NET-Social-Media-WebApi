using Microsoft.AspNetCore.Mvc;
using Social_Media_API.Models;
using Social_Media_API.Models.PostModels;
using Microsoft.AspNetCore.JsonPatch;
using AutoMapper;
using Social_Media_API.Services.Repository;
using System.Net;


namespace Social_Media_API.Controllers
{
    //api controller
    [ApiController] //enables data annotations on models errors

    //route to controller
    // [Route("api/[controller]")]
    [Route("api/PostAPI")] //if used somewhere to keep same name
    public class PostAPIController : ControllerBase //for api no support for MVC views --> less overhead
    {

        private readonly ILogger<PostAPIController> _logger;
        private readonly IPostRepository _dbPost;
        private readonly IMapper _mapper;
        protected APIResponse _response;


        public PostAPIController(ILogger<PostAPIController> logger, IPostRepository dbPost, IMapper mapper)
        {
            //for logging
            _logger = logger;
            _dbPost = dbPost;
            _mapper = mapper;
            this._response = new(); //initialize as empty
        }


        //> GET ALL |-----------------------------------

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetPosts() //** ActionResult for response type
        {

            try
            {
                _logger.LogInformation("Returning whole table");
                IEnumerable<Post> postList = await _dbPost.GetAllAsync();
                _response.Result = _mapper.Map<List<PostDTO>>(postList);
                _response.StatusCode = HttpStatusCode.OK;

                return Ok(_response); //returns 200 ok w/ content
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        //> GET ONE |-----------------------------------

        // [HttpGet("id")]
        // Documenting possible response types
        // [ProducesResponseType(200,Type=typeof(PostDTO))] //! specify type if not returned in ActionResult
        [HttpGet("{id:int}", Name = "GetPost")] // with type and explicit name (optional)
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetPost(int id)
        {

            try
            {
                if (id == 0)
                {
                    _logger.LogError("Id doesn't exist!!");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var post = await _dbPost.GetAsync(e => e.Id == id);

                if (post == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<PostDTO>(post);
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

        public async Task<ActionResult<APIResponse>> CreatePost([FromBody] CreatePostDTO createDTO)
        {

            try
            {
                //! if [ApiController] removed  or custom validation
                //! need to EXPLICITLY CHECK
                // if(!ModelState.IsValid){
                //     return BadRequest(ModelState); //returns error
                // }

                //*Validation
                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }

                //! CUSTOM ERROR
                //unique constraint
                if (await _dbPost.GetAsync(e => e.Title.ToLower() == createDTO.Title.ToLower()) != null)
                {
                    // custom error message
                    //unique key  ,  error message
                    ModelState.AddModelError("CustomError", "Title already exists!");
                    return BadRequest(ModelState);
                }

                //retrieving highest id in list + 1 , //! not needed in ef core --> auto increment

                //adding it to DB
                //* convert to post
                Post post = _mapper.Map<Post>(createDTO);

                await _dbPost.CreateAsync(post);

                //return create object with new id
                // return Ok(createDTO);

                _response.Result = _mapper.Map<PostDTO>(post);
                _response.StatusCode = HttpStatusCode.OK;

                // instead of returning OK
                //! usually route LOCATION where created record can be retrievd is returned
                //** route name ,   parameter           , createdobject
                //! get villa is invoked 
                return CreatedAtRoute("GetPost", new { id = post.Id }, _response); //returns 201
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }


        //> DELETE |-----------------------------------

        [HttpDelete("{id:int}", Name = "DeletePost")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> DeletePost(int id)
        {
            try
            {
                if (id == 0) { return BadRequest(); }

                var post = await _dbPost.GetAsync(e => e.Id == id);
                if (post == null)
                {
                    return NotFound();
                }

                await _dbPost.RemoveAsync(post);

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

        [HttpPut("{id:int}", Name = "UpdatePost")] //updates //! WHOLE object
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdatePost(int id, [FromBody] UpdatePostDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.Id)
                {
                    return BadRequest();
                }

                Post model = _mapper.Map<Post>(updateDTO);
                await _dbPost.UpdateAsync(model);

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


        //> PATCH  |-----------------------------------
        //! NOT CONSUMED IN COURSE --> NOT UPDATED TO USE APIRESPONSE
        //TODO check jsonpatch site for more info
        //NEED NUGGET PACKAGES  and Add to services
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("{id:int}", Name = "UpdatePartialPost")] //! updates one property at a time
        public async Task<ActionResult> UpdatePartialPost(int id, JsonPatchDocument<UpdatePostDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }

            //! get copy no tracking, since can't track same id multiple times
            var post = await _dbPost.GetAsync(e => e.Id == id, false);

            if (post == null)
            {
                return NotFound();
            }



            //other way around convert //! model to DTO to use with patch
            UpdatePostDTO modelDTO = _mapper.Map<UpdatePostDTO>(post);

            //update object
            patchDTO.ApplyTo(modelDTO, ModelState); //** 2nd arg : if any errors store in modelstate

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            //convert back to //! model to use with ef core
            Post model = _mapper.Map<Post>(modelDTO);

            await _dbPost.UpdateAsync(model);

            return NoContent();

        }

    }



}