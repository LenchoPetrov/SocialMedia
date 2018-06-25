namespace SocialMedia.Data.Models
{
    using System;

    public class Message
    {
        public int Id { get; set; }

        public string SenderId { get; set; }

        public virtual User Sender { get; set; }

        public string Content { get; set; }

        public string RecipientId { get; set; }

        public virtual User Recipient { get; set; }

        public DateTime Date { get; set; }
    }
}
