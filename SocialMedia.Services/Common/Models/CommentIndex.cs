namespace SocialMedia.Services.Common.Models
{
    using System;

    public class CommentIndex
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public int PictureId { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public string UserProfileImage { get; set; }

        public string UserName { get; set; }

        public string PictureOwnerUserName { get; set; }
    }
}
