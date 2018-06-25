namespace SocialMedia.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Picture
    {
        public int Id { get; set; }

        public string Description { get; set; }

        [Required]
        public byte[] Photo { get; set; }

        public DateTime PublishDate { get; set; }

        public virtual Album Album { get; set; }

        public int AlbumId { get; set; }

        public virtual User Owner { get; set; }

        public string OwnerId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
