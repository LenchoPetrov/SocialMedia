namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Services.Common.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SearchController : Controller
    {
        private readonly ISearchService search;

        public SearchController(ISearchService search)
        {
            this.search = search;
        }
     
        public IActionResult Users(string SearchString)
        {
            if (!String.IsNullOrEmpty(SearchString))
            {
                return View(this.search.SearchUsers(SearchString));
            }
            return View(this.search.AllUsers());
        }

        public IActionResult Pictures(string SearchString)
        {
            if (String.IsNullOrEmpty(SearchString))
            {
                return View();
            }
            return View(this.search.SearchPictures(SearchString));
        }
    }
}
