using Social_Media_API.Models.PostModels;

namespace Social_Media_API.Models.CommentModels
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Description { get; set; }
        // public string ImageURL { get; set; }
        public DateTime CreatedDate { get; set; }

        //!FOREIGN KEY
        [ForeignKey("Post")]
        public int PostID { get; set; }

        //! FOREIGN KEY MAPPER NAVIGATION PROPERTY1
        public Post Post { get; set; }

        public int Votes { get; set; } //to test filtering
    }
}