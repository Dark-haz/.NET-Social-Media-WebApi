using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Media_API.Models.DTO
{
    //used to take 
    //! User input
    public class UpdatePostDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required] //! different validation for update
        public String ImageUrl { get; set; }

    }
}