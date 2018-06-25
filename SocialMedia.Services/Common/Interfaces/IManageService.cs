namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Services.Common.Models;
    using System.Collections.Generic;

    public interface IManageService
    {
        HashSet<IndexPicture> GetMyPictures(string id);

        bool ChangePicture(byte[] profilePicture, string name);

        void SetName(string id, string name);
    }
}
