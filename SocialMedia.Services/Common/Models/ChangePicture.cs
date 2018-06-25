namespace SocialMedia.Services.Common.Models
{
    using Microsoft.AspNetCore.Http;

    public class ChangePicture
    {
        public IFormFile ProfilePicture { get; set; }
    }
}
