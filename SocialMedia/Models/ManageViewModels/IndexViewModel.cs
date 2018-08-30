namespace SocialMedia.Models.ManageViewModels
{
    using SocialMedia.Services.Common.Models;
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public string Username { get; set; }

        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public string UserId { get; set; }

        public FollowInfo FollowInfo { get; set; }

        public HashSet<IndexPicture> Pictures { get; set; } = new HashSet<IndexPicture>();
    }
}
