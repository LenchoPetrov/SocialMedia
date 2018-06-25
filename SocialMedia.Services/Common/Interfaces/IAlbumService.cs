using SocialMedia.Services.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Services.Common.Interfaces
{
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
