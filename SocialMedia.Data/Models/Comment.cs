namespace SocialMedia.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public int PictureId { get; set; }

        public virtual Picture Picture { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
