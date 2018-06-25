namespace SocialMedia.Services.Common.Models
{
    using System.Collections.Generic;

    public class UserAlbums
    {
        public string UserName { get; set; }

        public IEnumerable<AlbumInfo> Albums { get; set; }
    }
}