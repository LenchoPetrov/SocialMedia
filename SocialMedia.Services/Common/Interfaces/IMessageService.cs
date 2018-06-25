namespace SocialMedia.Services.Common.Interfaces
{
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Models;
    using System.Collections.Generic;

    public interface IMessageService
    {
        IEnumerable<User> GetAllUsers(string username);

        List<IndexMessage> TakeAllMyMessages(string username);

        void SendMessage(string username, SendMessage model);

        Messages TakeMessages(string recepientId, string senderId, string name);
    }
}
