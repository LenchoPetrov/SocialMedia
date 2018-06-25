namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FollowerService : IFollowerService
    {
        private readonly SocialMediaDbContext db;

        public FollowerService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public void Follow(string username, string followedUserId)
        {
            var user = this.db.Users.FirstOrDefault(u => u.UserName == username);
            var followedUser = this.db.Users.FirstOrDefault(u => u.Id == followedUserId);
            var follower = new Follower
            {
                User = user,
                UserId = user.Id,
                Followed = followedUser,
                FollowedId = followedUserId
            };

            this.db.Add(follower);
            this.db.SaveChanges();
        }

        public void Unfollow(string username, string followedUserId)
        {
            var user = this.db.Users.FirstOrDefault(u => u.UserName == username);
            var follower = this.db.Followers.FirstOrDefault(f => f.UserId == user.Id && f.FollowedId == followedUserId);

            this.db.Remove(follower);
            this.db.SaveChanges();
        }

        public List<Followers> GetAllFollowed(string userId)
        {
            return this.db.Followers.Where(f => f.UserId == userId).Select(f => new Followers
            {
                Id = f.FollowedId,
                Username = this.db.Users.FirstOrDefault(u => u.Id == f.FollowedId).UserName,
                Name = this.db.Users.FirstOrDefault(u => u.Id == f.FollowedId).Name,
                UserProfileImage = this.db.Users.FirstOrDefault(u => u.Id == f.FollowedId).ProfilePicture == null ?
                                  null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(this.db.Users.FirstOrDefault(u => u.Id == f.FollowedId).ProfilePicture))
            }).ToList();
        }

        public List<Followers> GetAllFollowers(string userId)
        {
            return this.db.Followers.Where(f => f.FollowedId == userId).Select(f => new Followers
            {
                Id = f.UserId,
                Username = this.db.Users.FirstOrDefault(u => u.Id == f.UserId).UserName,
                Name = this.db.Users.FirstOrDefault(u => u.Id == f.UserId).Name,
                UserProfileImage = this.db.Users.FirstOrDefault(u => u.Id == f.UserId).ProfilePicture == null ?
                          null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(this.db.Users.FirstOrDefault(u => u.Id == f.UserId).ProfilePicture))
            }).ToList();
        }
    }
}
