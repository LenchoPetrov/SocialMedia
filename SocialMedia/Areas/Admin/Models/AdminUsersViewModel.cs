namespace SocialMedia.Areas.Admin.Models
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SocialMedia.Data.Models;
    using SocialMedia.Services.Admin.Models;

    public class AdminUsersViewModel
    {
        public IEnumerable<SelectListItem> Roles { get; set; }

        public Task<IEnumerable<AdminUserListingModel>> Users { get; set; }

    }
}
