namespace SocialMedia.Services.Common.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;

    public class SendMessage
    {
        public string RecepientId { get; set; }

        public string Content { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }
    }
}
