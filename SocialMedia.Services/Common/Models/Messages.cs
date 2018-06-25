namespace SocialMedia.Services.Common.Models
{
    using SocialMedia.Data.Models;
    using System.Collections.Generic;

    public class Messages
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserProfileImage { get; set; }

        public string RecipientName { get; set; }

        public string RecipientProfileImage { get; set; }

        public string RecipientId { get; set; }

        public List<Message> SendedMessages { get; set; }
    }
}
