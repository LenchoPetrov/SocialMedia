namespace SocialMedia.Services.Admin.Implementations
{
    using Microsoft.AspNetCore.Identity;
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Admin.Interfaces;
    using SocialMedia.Services.Admin.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AdminService : IAdminService
    {
        private readonly SocialMediaDbContext db;

        private readonly RoleManager<IdentityRole> roleManager;

        private readonly UserManager<User> _userManager;

        public AdminService(SocialMediaDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IEnumerable<AdminUserListingModel>> All()
        {
            var users = new List<AdminUserListingModel>();
            foreach (var u in this.db.Users)
            {
                var boola = await _userManager.IsInRoleAsync(u, "Administrator");

                var user = new AdminUserListingModel
                {
                    Name = u.Name,
                    Username = u.UserName,
                    Email = u.Email,
                    Id = u.Id,
                };
                user.IsInRole = boola;
                users.Add(user);
            }
            return users.OrderBy(u => u.Username);
        }

        public void DeleteUser(string userId)
        {
            var user = this.db.Users.FirstOrDefault(u => u.Id == userId);
            var comments = this.db.Comments.Where(c => c.UserId == userId).ToHashSet();
            var pictures = this.db.Pictures.Where(c => c.OwnerId == userId).ToHashSet();
            var albums = this.db.Albums.Where(c => c.UserId == userId).ToHashSet();
            var followers = this.db.Followers.Where(c => c.UserId == userId || c.FollowedId == userId).ToHashSet();
            var messages = this.db.Messages.Where(c => c.RecipientId == userId || c.SenderId == userId).ToHashSet();

            this.db.RemoveRange(comments);
            this.db.SaveChanges();
            foreach (var picture in pictures)
            {
                var commentsForPicture = this.db.Comments.Where(c => c.PictureId == picture.Id).ToHashSet();
                this.db.RemoveRange(commentsForPicture);
                this.db.SaveChanges();
            }

            this.db.RemoveRange(pictures);
            this.db.SaveChanges();
            this.db.RemoveRange(albums);
            this.db.SaveChanges();
            this.db.RemoveRange(followers);
            this.db.SaveChanges();
            this.db.RemoveRange(messages);
            this.db.SaveChanges();

            this.db.Users.Remove(user);
            this.db.SaveChanges();
        }

        public DeleteUserViewModel GetUserDelete(string userId)
        {
            return this.db.Users.Select(u => new DeleteUserViewModel
            {
                Id = u.Id,
                BirthDate = u.BirthDate,
                Country = u.Country,
                Name = u.Name,
                Email = u.Email,
                Town = u.Town,
                Username = u.UserName,
                Comments = u.Comments,
                Followed = u.Followed,
                Followers = u.Followers,
                MessagesReceive = u.MessagesReceive,
                MessagesSend = u.MessagesSend,
                Pictures = u.Pictures,
                ProfilePicture = u.ProfilePicture,
                Albums = u.Albums
            })
            .FirstOrDefault(u => u.Id == userId);
        }

        public void EditUser(EditUserViewModel model)
        {
            var user = this.db.Users.FirstOrDefault(u => u.Id == model.Id);

            user.Name = model.Name;
            user.Email = model.Email;
            user.PhoneNumber = model.PhoneNumber;
            user.BirthDate = model.BirthDate;

            this.db.Update(user);
            this.db.SaveChanges();
        }

        public EditUserViewModel GetUserEdit(string userId)
        {
            return this.db.Users.Select(u => new EditUserViewModel
            {
                Id = u.Id,
                BirthDate = u.BirthDate,
                Name = u.Name,
                Email = u.Email,
                Username = u.UserName,
            }).FirstOrDefault(u => u.Id == userId);
        }
    }
}
