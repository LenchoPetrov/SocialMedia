namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Services.Common.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISearchService
    {
        Task<IEnumerable<AllUsers>> AllUsers();

        Task<IEnumerable<AllUsers>> SearchUsers(string searchString);

        Task<IEnumerable<PictureSearch>> SearchPictures(string searchString);
    }
}
