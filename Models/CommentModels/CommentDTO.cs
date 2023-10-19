using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Social_Media_API.Models.PostModels;

namespace Social_Media_API.Models.CommentModels
{
    public class CommentDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

        //! FOREIGN KEY REQUIRED
        [Required]
        public int PostID { get; set; }

        //! NAVIGATION PROPERTY DTO 
        public PostDTO Post { get; set; }

        public int Votes { get; set; } //to test filtering
    }
}