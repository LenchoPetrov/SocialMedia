namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SearchService : ISearchService
    {
        private readonly SocialMediaDbContext db;

        public SearchService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<AllUsers> AllUsers()
        {
            return this.db.Users.Select(u=>new AllUsers
            {
                Id = u.Id,
                Email = u.Email,
                Name = u.Name,
                Username = u.UserName
            }).ToList();
        }

        public IEnumerable<PictureSearch> SearchPictures(string searchString)
        {
            return this.db.Pictures.Where(p => p.Description.Contains(searchString))
                          .Select(p => new PictureSearch
                          {
                              Id = p.Id,
                              Photo = p.Photo == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(p.Photo)),
                          }).ToList();
        }

        public IEnumerable<AllUsers> SearchUsers(string searchString)
        {
            return this.db.Users
                .Where(u => u.Name.Contains(searchString) || u.UserName.Contains(searchString)).Select(u => new AllUsers
                {
                    Id = u.Id,
                    Email = u.Email,
                    Name = u.Name,
                    Username = u.UserName
                }).ToList();
        }
    }
}
