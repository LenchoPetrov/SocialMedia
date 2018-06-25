namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Services.Common.Models;
    using System.Collections.Generic;

    public interface IFollowerService
    {
        void Follow(string username, string followedUserId);

        void Unfollow(string username, string followedUserId);

        List<Followers> GetAllFollowed(string userId);

        List<Followers> GetAllFollowers(string userId);
    }
}
