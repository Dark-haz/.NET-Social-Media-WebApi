using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Media_API.Models.PostModels
{
    //used to take 
    //! User input
    public class UpdatePostDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

        [Required] //! different validation for update exp
        public String ImageUrl { get; set; }

    }
}