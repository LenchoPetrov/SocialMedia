namespace SocialMedia.Services.Common.Models
{
    using SocialMedia.Data.Models;
    using System.Collections.Generic;

    public class PicturesAlbum
    {
        public HashSet<Picture> Pictures { get; set; } = new HashSet<Picture>();

        public string AlbumName { get; set; }

        public int AlbumId { get; set; }

        public string UserName { get; set; }
    }
}
