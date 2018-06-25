namespace SocialMedia.Services.Common.Models
{
    using System.Collections.Generic;

    public class HomeViewModel
    {
        public HashSet<IndexPicture> Pictures { get; set; } = new HashSet<IndexPicture>();
    }
}
