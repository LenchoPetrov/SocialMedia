namespace SocialMedia.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string UserId { get; set; }

        public int AlbumProfileImageId { get; set; }

        public User User { get; set; }

        public List<Picture> Pictures { get; set; } = new List<Picture>();
    }
}
