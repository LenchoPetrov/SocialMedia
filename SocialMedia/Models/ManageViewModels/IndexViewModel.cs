using SocialMedia.Services.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models.ManageViewModels
{
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
