namespace SocialMedia.Services.Common.Models
{
    using System;
    using System.Collections.Generic;

    public class IndexPicture
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }

        public byte[] PhotoToBytes { get; set; }

        public DateTime PublishDate { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string UserProfilePhoto { get; set; }

        public int AlbumId { get; set; }

        public string UserId { get; set; }

        public List<CommentIndex> Comments { get; set; } = new List<CommentIndex>();
    }
}
