namespace SocialMedia.Services.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class PictureInfo
    {
        public string Description { get; set; }

        public DateTime PublishDate { get; set; }

        [Required]
        public string AlbumName { get; set; }
    }
}
