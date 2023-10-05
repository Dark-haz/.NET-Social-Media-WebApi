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


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<PostDTO>> GetPosts() //** ActionResult for response type
        {
            // return PostStore.postList;
            _logger.LogInformation("Returning whole table");
            return Ok(_db.Posts.ToList()); //returns 200 ok w/ content
        }
        

        // [HttpGet("id")]
        // Documenting possible response types
        // [ProducesResponseType(200,Type=typeof(PostDTO))] //! specify type if not returned in ActionResult
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id:int}",Name = "GetPost")] // with type and explicit name (optional)
        public ActionResult<PostDTO> GetPost(int id)
        {
            if(id == 0){
                _logger.LogError("Id doesn't exist!!");
                return BadRequest();
            }

            var post = _db.Posts.FirstOrDefault(p=>p.Id == id);

            if(post == null){
                return NotFound();
            }

            return Ok(post);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<PostDTO> CreatePost([FromBody] PostDTO postDTO){

            //! if [ApiController] removed  or custom validation
            //! need to EXPLICITLY CHECK
            // if(!ModelState.IsValid){
            //     return BadRequest(ModelState); //returns error
            // }

            //*Validation
            if(postDTO == null){
                return BadRequest(postDTO);
            }

            if(postDTO.Id>0){ //>0 --> not a create request

                //return custom status not in default ActionResult
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            //! CUSTOM ERROR
            //unique constraint
            if(_db.Posts.FirstOrDefault(e=>e.Title.ToLower() == postDTO.Title.ToLower()) != null ){
                // custom error message
                                        //unique key  ,  error message
                ModelState.AddModelError("CustomError","Title already exists!");
                return BadRequest(ModelState);
            }

            //retrieving highest id in list + 1 , //! not needed in ef core --> auto increment
            // postDTO.Id = PostStore.postList.OrderByDescending(u=>u.Id).FirstOrDefault().Id + 1;

            //adding it to DB
            Post model = new Post{
                Id = postDTO.Id,
                Title = postDTO.Title,
                Description = postDTO.Description,
                ImageUrl = postDTO.ImageUrl,
            };

            _db.Posts.Add(model);
            _db.SaveChanges();

            //return create object with new id
            // return Ok(postDTO);

            // instead of returning OK
            //! usually route LOCATION where created record can be retrievd is returned
                                 //** route name ,   parameter           , createdobject
                                 //! get villa is invoked 
            return CreatedAtRoute("GetPost" , new { id = postDTO.Id} , postDTO); //returns 201
        }
    

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}" , Name = "DeletePost")]
        public IActionResult DeletePost(int id)
        {
            if(id == 0){return BadRequest();}

            var post = _db.Posts.FirstOrDefault(e=> e.Id == id);
            if(post == null){
                return NotFound();
            }

            _db.Posts.Remove(post);
            _db.SaveChanges();

            return NoContent(); //in deleting we return nothing
        }
    

    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut("{id:int}" , Name = "UpdatePost")] //updates //! WHOLE object
    public IActionResult UpdatePost(int id, [FromBody] PostDTO postDTO)
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
        _db.SaveChanges();

        return NoContent();
    }


    // HTTP PATCH  |-----------------------------------
    //TODO check jsonpatch site for more info
    //NEED NUGGET PACKAGES  and Add to services
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPatch("{id:int}" , Name = "UpdatePartialPost")] //! updates one property at a time
    public IActionResult UpdatePartialPost(int id , JsonPatchDocument<PostDTO> patchDTO)
    {
        if(patchDTO == null || id == 0){
            return BadRequest();
        }

        //! get copy no tracking, since can't track same id multiple times
        var post = _db.Posts.AsNoTracking().FirstOrDefault(e=>e.Id == id);

        if(post == null){
            return NotFound();
        }

        

        //other way around convert //! model to DTO to use with patch
         PostDTO modelDTO = new PostDTO{
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
        _db.SaveChanges();

        return NoContent();

    }

    }



}