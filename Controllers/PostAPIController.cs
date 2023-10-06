using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Social_Media_API.Models;
using Social_Media_API.Models.DTO;
using Social_Media_API.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Social_Media_API.Services.Repository;


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
        private readonly IPostRepository _dbPost ;
        private readonly IMapper _mapper;


        public PostAPIController(ILogger<PostAPIController> logger , IPostRepository dbPost ,IMapper mapper)
        {
            //for logging
            _logger = logger;    
            _dbPost = dbPost;
            _mapper = mapper;
        }


    //> GET ALL |-----------------------------------

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetPosts() //** ActionResult for response type
        {
            // return PostStore.postList;
            _logger.LogInformation("Returning whole table");
            IEnumerable<Post> postList = await _dbPost.GetAllAsync();

            return Ok(_mapper.Map<List<PostDTO>>(postList)); //returns 200 ok w/ content
        }
        
    //> GET ONE |-----------------------------------

        // [HttpGet("id")]
        // Documenting possible response types
        // [ProducesResponseType(200,Type=typeof(PostDTO))] //! specify type if not returned in ActionResult
        [HttpGet("{id:int}",Name = "GetPost")] // with type and explicit name (optional)
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PostDTO>> GetPost(int id)
        {
            if(id == 0){
                _logger.LogError("Id doesn't exist!!");
                return BadRequest();
            }


            var post = await _dbPost.GetAsync(e=>e.Id == id);

            if(post == null){
                return NotFound();
            }

            return Ok(_mapper.Map<PostDTO>(post));
        }

     //> CREATE |-----------------------------------

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<PostDTO>> CreatePost([FromBody] CreatePostDTO createDTO){

            //! if [ApiController] removed  or custom validation
            //! need to EXPLICITLY CHECK
            // if(!ModelState.IsValid){
            //     return BadRequest(ModelState); //returns error
            // }

            //*Validation
            if(createDTO == null){
                return BadRequest(createDTO);
            }

            //! CUSTOM ERROR
            //unique constraint
            if(await _dbPost.GetAsync(e=>e.Title.ToLower() == createDTO.Title.ToLower()) != null ){
                // custom error message
                                        //unique key  ,  error message
                ModelState.AddModelError("CustomError","Title already exists!");
                return BadRequest(ModelState);
            }

            //retrieving highest id in list + 1 , //! not needed in ef core --> auto increment

            //adding it to DB
            //* convert to post
            Post model = _mapper.Map<Post>(createDTO);
            
            await _dbPost.CreateAsync(model);

            //return create object with new id
            // return Ok(createDTO);

            // instead of returning OK
            //! usually route LOCATION where created record can be retrievd is returned
                                 //** route name ,   parameter           , createdobject
                                 //! get villa is invoked 
            return CreatedAtRoute("GetPost" , new { id = model.Id} , model); //returns 201
        }
    

     //> DELETE |-----------------------------------

        [HttpDelete("{id:int}" , Name = "DeletePost")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeletePost(int id)
        {
            if(id == 0){return BadRequest();}

            var post = await _dbPost.GetAsync(e=> e.Id == id);
            if(post == null){
                return NotFound();
            }

            await _dbPost.RemoveAsync(post);

            return NoContent(); //in deleting we return nothing
        }
    
    //>  PUT|-----------------------------------
    
    [HttpPut("{id:int}" , Name = "UpdatePost")] //updates //! WHOLE object
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdatePost(int id, [FromBody] UpdatePostDTO updateDTO)
    {
        if(updateDTO == null || id != updateDTO.Id){
            return BadRequest();
        }

        Post model = _mapper.Map<Post>(updateDTO);
        await _dbPost.UpdateAsync(model);

        return NoContent();
    }


    //> PATCH  |-----------------------------------
    //TODO check jsonpatch site for more info
    //NEED NUGGET PACKAGES  and Add to services
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPatch("{id:int}" , Name = "UpdatePartialPost")] //! updates one property at a time
    public async Task<ActionResult> UpdatePartialPost(int id , JsonPatchDocument<UpdatePostDTO> patchDTO)
    {
        if(patchDTO == null || id == 0){
            return BadRequest();
        }

        //! get copy no tracking, since can't track same id multiple times
        var post = await _dbPost.GetAsync(e=>e.Id == id,false);

        if(post == null){
            return NotFound();
        }

        

        //other way around convert //! model to DTO to use with patch
         UpdatePostDTO modelDTO = _mapper.Map<UpdatePostDTO>(post);

        //update object
        patchDTO.ApplyTo(modelDTO,ModelState); //** 2nd arg : if any errors store in modelstate

        if(!ModelState.IsValid){
            return BadRequest();
        }

        //convert back to //! model to use with ef core
        Post model = _mapper.Map<Post>(modelDTO);

        await _dbPost.UpdateAsync(model);

        return NoContent();

    }

    }



}