namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Services.Common.Models;

    public interface IAlbumService
    {
        int CreateAlbum(string title, string username);

        string GetAlbumTitle(int albumId);

        void DeleteAlbum(int id);

        void EditAlbum(int id, string title);

        UserAlbums GetAllAlbums(string id);

        int GetPicturesCount(int albumId);

        PicturesAlbum GetAllPicturesForThisAlbum(int id);

        bool UserIsOwner(int id, string name);

        void SetAlbumPicture(int photoId, int albumId);

        string GetUserId(int albumId);
    }
}
