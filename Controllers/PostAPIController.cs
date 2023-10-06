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
        private readonly AppDbContext _db ;

        public PostAPIController(ILogger<PostAPIController> logger , AppDbContext db)
        {
            //for logging
            _logger = logger;    
            _db = db;
        }


    //> GET ALL |-----------------------------------

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetPosts() //** ActionResult for response type
        {
            // return PostStore.postList;
            _logger.LogInformation("Returning whole table");
            return Ok(await _db.Posts.ToListAsync()); //returns 200 ok w/ content
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

            var post = await _db.Posts.FirstOrDefaultAsync(p=>p.Id == id);

            if(post == null){
                return NotFound();
            }

            return Ok(post);
        }

     //> CREATE |-----------------------------------

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<PostDTO>> CreatePost([FromBody] CreatePostDTO postDTO){

            //! if [ApiController] removed  or custom validation
            //! need to EXPLICITLY CHECK
            // if(!ModelState.IsValid){
            //     return BadRequest(ModelState); //returns error
            // }

            //*Validation
            if(postDTO == null){
                return BadRequest(postDTO);
            }

            //! CUSTOM ERROR
            //unique constraint
            if(await _db.Posts.FirstOrDefaultAsync(e=>e.Title.ToLower() == postDTO.Title.ToLower()) != null ){
                // custom error message
                                        //unique key  ,  error message
                ModelState.AddModelError("CustomError","Title already exists!");
                return BadRequest(ModelState);
            }

            //retrieving highest id in list + 1 , //! not needed in ef core --> auto increment

            //adding it to DB
            Post model = new Post{
                Title = postDTO.Title,
                Description = postDTO.Description,
                ImageUrl = postDTO.ImageUrl,
                // CreatedDate = something  //! it's missing for some reason
            };

            await _db.Posts.AddAsync(model);
            await _db.SaveChangesAsync();

            //return create object with new id
            // return Ok(postDTO);

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

            var post = await _db.Posts.FirstOrDefaultAsync(e=> e.Id == id);
            if(post == null){
                return NotFound();
            }

            _db.Posts.Remove(post);
            await _db.SaveChangesAsync();

            return NoContent(); //in deleting we return nothing
        }
    
    //>  PUT|-----------------------------------
    
    [HttpPut("{id:int}" , Name = "UpdatePost")] //updates //! WHOLE object
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdatePost(int id, [FromBody] UpdatePostDTO postDTO)
    {
        if(postDTO == null || id != postDTO.Id){
            return BadRequest();
        }

        Post model = new Post{
            Id = postDTO.Id,
            Title = postDTO.Title,
            Description = postDTO.Description,
            ImageUrl = postDTO.ImageUrl,
        };

        _db.Posts.Update(model);
        await _db.SaveChangesAsync();

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
        var post = await _db.Posts.AsNoTracking().FirstOrDefaultAsync(e=>e.Id == id);

        if(post == null){
            return NotFound();
        }

        

        //other way around convert //! model to DTO to use with patch
         UpdatePostDTO modelDTO = new UpdatePostDTO{
            Id = post.Id,
            Title = post.Title,
            Description = post.Description,
            ImageUrl = post.ImageUrl,
        };

        //update object
        patchDTO.ApplyTo(modelDTO,ModelState); //** 2nd arg : if any errors store in modelstate

        if(!ModelState.IsValid){
            return BadRequest();
        }

        //convert back to //! model to use with ef core
        Post model = new Post{
            Id = modelDTO.Id,
            Title = modelDTO.Title,
            Description = modelDTO.Description,
            ImageUrl = modelDTO.ImageUrl,
        };

        _db.Posts.Update(model);
        await _db.SaveChangesAsync();

        return NoContent();

    }

    }



}