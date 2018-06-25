namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Services.Common.Models;

    public interface IHomeService
    {
        HomeViewModel GetAllPictures(string username);
    }
}
