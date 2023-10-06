using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Media_API.Models.DTO
{
    //used to take 
    //! User input
    public class CreatePostDTO
    {
        // public int Id { get; set; } no need for id in create , //! automatically populated

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        public string Description { get; set; }

        public String ImageUrl { get; set; }

    }
}