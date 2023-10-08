using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Media_API.Models.CommentModels
{
    public class CreateCommentDTO
    {

        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

        //! FOREIGN KEY REQUIRED
        [Required]
        public int PostID { get; set; }
    }
}