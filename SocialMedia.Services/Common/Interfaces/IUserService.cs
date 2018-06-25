namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Models;
    using System.Collections.Generic;

    public interface IUserService
    {
        HashSet<IndexPicture> GetMyPictures(string id);

        User GetUser(string id);

        string GetUserId(string name);

        FollowInfo IsFollowed(string id, string username);
    }
}
