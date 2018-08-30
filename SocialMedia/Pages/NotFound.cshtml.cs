namespace SocialMedia.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class NotFoundModel : PageModel
    {
        public string NotFoundImage { get; set; }

        public void OnGet()
        {
            NotFoundImage = "/images/Page-not-found.png";
        }
    }
}