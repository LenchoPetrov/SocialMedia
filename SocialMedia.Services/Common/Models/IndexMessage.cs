namespace SocialMedia.Services.Common.Models
{
    using System;

    public class IndexMessage
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string RecipientName { get; set; }

        public string RecipientId { get; set; }

        public string SenderId { get; set; }

        public DateTime Date { get; set; }

        public string RecipientProfileImage { get; set; }
    }
}
