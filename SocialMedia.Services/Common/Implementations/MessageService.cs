namespace SocialMedia.Services.Common.Implementations
{
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MessageService : IMessageService
    {
        private readonly SocialMediaDbContext db;

        public MessageService(SocialMediaDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<User> GetAllUsers(string username)
        {
            return this.db.Users.Where(u => u.UserName != username);
        }

        public void SendMessage(string username, SendMessage model)
        {
            var user = this.db.Users.FirstOrDefault(u => u.UserName == username);
            var message = new Message
            {
                Sender = user,
                SenderId = user.Id,
                RecipientId = model.RecepientId,
                Recipient = this.db.Users.FirstOrDefault(u => u.Id == model.RecepientId),
                Date = DateTime.UtcNow,
                Content = model.Content
            };

            this.db.Add(message);
            this.db.SaveChanges();
        }

        public List<IndexMessage> TakeAllMyMessages(string username)
        {
            var userId = this.db.Users.FirstOrDefault(u => u.UserName == username).Id;
            var list = this.db.Messages.Where(m => m.RecipientId == userId || m.SenderId == userId).Select(m => new IndexMessage
            {
                Id = m.Id,
                Content = m.Content,
                SenderId = m.SenderId,
                RecipientName = this.db.Users.FirstOrDefault(u => u.Id == m.RecipientId).Id == userId ? this.db.Users.FirstOrDefault(u => u.Id == m.SenderId).Name :
                this.db.Users.FirstOrDefault(u => u.Id == m.RecipientId).Name,
                Date = m.Date,
                RecipientId = m.RecipientId
            }).OrderByDescending(m => m.Date).GroupBy(m => m.RecipientId).Select(g => g.First()).OrderByDescending(m => m.Date).ToList();

            var list2 = new List<IndexMessage>();

            foreach (var message in list)
            {
                if (!list2.Any(m => (m.SenderId == message.SenderId && m.RecipientId == message.RecipientId) || (m.SenderId == message.RecipientId && m.RecipientId == message.SenderId)))
                {
                    if (message.RecipientId != userId)
                    {
                        message.RecipientProfileImage = this.db.Users.FirstOrDefault(u => u.Id == message.RecipientId).ProfilePicture == null ?
                                                 null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(this.db.Users.FirstOrDefault(u => u.Id == message.RecipientId).ProfilePicture));
                    }
                    else
                    {
                        message.RecipientProfileImage = this.db.Users.FirstOrDefault(u => u.Id == message.SenderId).ProfilePicture == null ?
                                             null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(this.db.Users.FirstOrDefault(u => u.Id == message.SenderId).ProfilePicture));
                    }
                    list2.Add(message);
                }
            }

            return list2;
        }

        public Messages TakeMessages(string recepientId, string senderId, string name)
        {
            var user = this.db.Users.FirstOrDefault(u => u.UserName == name);
            User recepient;

            if (user.Id == recepientId)
            {
                recepient = this.db.Users.FirstOrDefault(u => u.Id == senderId);
            }
            else
            {
                recepient = this.db.Users.FirstOrDefault(u => u.Id == recepientId);
            }

            return new Messages
            {
                UserId = user.Id,
                UserName = user.Name,
                UserProfileImage = user.ProfilePicture == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(user.ProfilePicture)),
                RecipientName = recepient.Name,
                RecipientId = recepient.Id,
                RecipientProfileImage = recepient.ProfilePicture == null ? null : String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(recepient.ProfilePicture)),
                SendedMessages = this.db.Messages.Where(m => (m.SenderId == user.Id && m.RecipientId == recepient.Id) || (m.SenderId == recepient.Id && m.RecipientId == user.Id)).ToList()
            };
        }
    }
}
