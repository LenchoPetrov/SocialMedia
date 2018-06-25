namespace SocialMedia.Services.Admin.Models
{
    using SocialMedia.Data.Models;
    using System;
    using System.Collections.Generic;

    public class DeleteUserViewModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public byte[] ProfilePicture { get; set; }

        public string Town { get; set; }

        public string Country { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Message> MessagesSend { get; set; }

        public virtual ICollection<Message> MessagesReceive { get; set; }

        public virtual ICollection<Follower> Followers { get; set; }

        public virtual ICollection<Follower> Followed { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

    }
}
