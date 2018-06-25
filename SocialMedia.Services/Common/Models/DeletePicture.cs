namespace SocialMedia.Services.Common.Models
{
    using System;

    public class DeletePicture
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime PublishDate { get; set; }

        public int AlbumId { get; set; }

        public string AlbumName { get; set; }
    }
}
