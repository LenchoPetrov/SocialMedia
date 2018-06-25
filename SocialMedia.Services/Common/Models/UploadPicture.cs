namespace SocialMedia.Services.Common.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SocialMedia.Data.Models;
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;

    public class UploadPicture 
    {
        public string Description { get; set; }

        public IFormFile Photo { get; set; }

        public IEnumerable<SelectListItem> Albums { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }

        public string AlbumTitle { get; set; }

        public int Id { get; set; }

        public DateTime PublishDate { get; set; }

        public virtual User Owner { get; set; }

        public string OwnerId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
