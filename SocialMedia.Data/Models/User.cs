namespace SocialMedia.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        [MinLength(4)]
        [MaxLength(120)]
        [Required]
        public string Name { get; set; }

        public byte[] ProfilePicture { get; set; }

        [MinLength(2)]
        [MaxLength(40)]
        public string Town { get; set; }

        [MinLength(2)]
        [MaxLength(40)]
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
