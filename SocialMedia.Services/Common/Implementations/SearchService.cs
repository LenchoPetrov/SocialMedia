namespace SocialMedia.Services.Common.Implementations
{
    using Microsoft.EntityFrameworkCore;
    using SocialMedia.Data.Data;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SearchService : ISearchService
    {
        private readonly SocialMediaDbContext db;

        public SearchService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<AllUsers>> AllUsers()
        {
            return await this.db.Users.Select(u => new AllUsers
            {
                Id = u.Id,
                Email = u.Email,
                Name = u.Name,
                Username = u.UserName,
                ProfileImage = u.ProfilePicture == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(u.ProfilePicture))
            }).ToListAsync();
        }

        public async Task<IEnumerable<PictureSearch>> SearchPictures(string searchString)
        {
            return await this.db.Pictures.Where(p => p.Description.Contains(searchString))
                          .Select(p => new PictureSearch
                          {
                              Id = p.Id,
                              Photo = p.Photo == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(p.Photo)),
                          }).ToListAsync();
        }

        public async Task<IEnumerable<AllUsers>> SearchUsers(string searchString)
        {
            return await this.db.Users
                .Where(u => u.Name.Contains(searchString) || u.UserName.Contains(searchString)).Select(u => new AllUsers
                {
                    Id = u.Id,
                    Email = u.Email,
                    Name = u.Name,
                    Username = u.UserName,
                    ProfileImage = u.ProfilePicture == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(u.ProfilePicture))
                }).ToListAsync();
        }
    }
}
