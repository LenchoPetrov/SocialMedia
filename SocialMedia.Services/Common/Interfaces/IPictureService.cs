namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Models;
    using System.Collections.Generic;

    public interface IPictureService
    {
        IEnumerable<Album> GetAllAlbums(string name);

        PictureInfo GetPictureInfo(int id);

        void DeletePicture(int id);

        void EditPicture(int id, string description);

        IndexPicture GetPicture(int id);

        bool UserIsOwner(int id, string name);

        bool CreatePicture(string description, byte[] fileContents, int albumId);

        string GetUserId(int id);
    }
}
