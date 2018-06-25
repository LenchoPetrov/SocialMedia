namespace SocialMedia.Services.Common.Models
{
    using System.ComponentModel.DataAnnotations;

    public class DeleteAlbum
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int PicturesCount { get; set; }
    }
}
