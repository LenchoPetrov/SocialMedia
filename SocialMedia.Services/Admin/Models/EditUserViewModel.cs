namespace SocialMedia.Services.Admin.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Username has to be at least 2 symbols.")]
        [MaxLength(40, ErrorMessage = "Username has to be maximum 40 symbols.")]
        public string Username { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Name has to be at least 4 symbols.")]
        [MaxLength(120, ErrorMessage = "Name has to be maximum 120 symbols.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Name has to contains only letters.")]
        public string Name { get; set; }

        [Display(Name = "Phone Number")]
        [MinLength(7, ErrorMessage = "Phone number has at least 9 numbers.")]
        [MaxLength(12, ErrorMessage = "Phone number has maximum 12 numbers.")]
        [RegularExpression(@"[0-9]{7,12}", ErrorMessage = "Phone number has contains only numbers.")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
