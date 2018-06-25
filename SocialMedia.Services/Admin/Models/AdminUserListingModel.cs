namespace SocialMedia.Services.Admin.Models
{
    public class AdminUserListingModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public bool IsInRole { get; set; }
    }
}
