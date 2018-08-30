namespace SocialMedia.Pages.Search
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using SocialMedia.Data.Data;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;

    public class Pictures2Model : PageModel
    {
        private readonly SocialMediaDbContext _db;

        private readonly ISearchService _search;

        public IEnumerable<PictureSearch> Pictures { get; set; }

        public Pictures2Model(SocialMediaDbContext db, ISearchService search)
        {
            _db = db;
            _search = search;
        }

        public async Task OnGetAsync()
        {
        }

        public async Task<IActionResult> OnPostPictures(string SearchString)
        {
            if (!String.IsNullOrEmpty(SearchString))
            {
                Pictures = await this._search.SearchPictures(SearchString);
            }
            return Page();
        }
    }
}