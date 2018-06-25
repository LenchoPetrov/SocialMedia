namespace SocialMedia.Data.Models
{
    public class Follower
    {
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string FollowedId { get; set; }

        public virtual User Followed { get; set; }
    }
}
