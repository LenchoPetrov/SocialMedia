namespace SocialMedia.Pages.Search
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using SocialMedia.Data.Data;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;

    [Authorize]
    public class UsersModel : PageModel
    {
        private readonly SocialMediaDbContext _db;

        private readonly ISearchService _search;

        public IEnumerable<AllUsers> Users { get; set; }

        public UsersModel(SocialMediaDbContext db, ISearchService search)
        {
            _db = db;
            _search = search;
        }

        public async Task<IActionResult> OnGetAsync()
        {

            Users = await this._search.AllUsers();
            return Page();
        }

        public async Task<IActionResult> OnPostUsers(string SearchString)
        {
            if (!String.IsNullOrEmpty(SearchString))
            {
                Users = await this._search.SearchUsers(SearchString);
            }
            else
            {
                Users = await this._search.AllUsers();
            }

            return Page();
        }
    }
}