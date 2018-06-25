namespace SocialMedia.Services.Common.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CreateAlbum
    {
        [Required]
        [MinLength(2, ErrorMessage = "Title has to be at least 2 symbols.")]
        [MaxLength(50, ErrorMessage = "Title has to be maximum 50 symbols.")]
        public string Title { get; set; }
    }
}
