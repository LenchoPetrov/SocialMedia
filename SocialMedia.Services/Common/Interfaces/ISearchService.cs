namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Services.Common.Models;
    using System.Collections.Generic;

    public interface ISearchService
    {
        IEnumerable<AllUsers> AllUsers();

        IEnumerable<AllUsers> SearchUsers(string searchString);

        IEnumerable<PictureSearch> SearchPictures(string searchString);
    }
}
