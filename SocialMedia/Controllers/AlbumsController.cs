namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AlbumsController : Controller
    {
        private readonly IAlbumService albums;

        public AlbumsController(IAlbumService albums)
        {
            this.albums = albums;
        }

        public IActionResult Album(int id)
        {
            return View(albums.GetAllPicturesForThisAlbum(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateAlbum model)
        {
            return RedirectToAction("Upload", "Pictures", new { albumTitle = model.Title });
        }

        public IActionResult Delete(int albumId)
        {
            if (albums.UserIsOwner(albumId, User.Identity.Name))
            {
                return View(new DeleteAlbum { Id = albumId, Title = albums.GetAlbumTitle(albumId), PicturesCount = albums.GetPicturesCount(albumId) });
            }
            else
            {
                return View(nameof(NotFound));
            }
        }

        [HttpPost]
        public IActionResult Destroy(int albumId)
        {
            var userId = albums.GetUserId(albumId);
            albums.DeleteAlbum(albumId);

            return RedirectToAction(nameof(Index), new { id = userId });
        }

        public IActionResult Edit(int albumId)
        {
            if (albums.UserIsOwner(albumId, User.Identity.Name))
            {
                return View(new EditAlbum { Id = albumId, Title = albums.GetAlbumTitle(albumId) });
            }
            else
            {
                return View(nameof(NotFound));
            }
        }

        [HttpPost]
        public IActionResult Edit(EditAlbum model)
        {
            albums.EditAlbum(model.Id, model.Title);

            return RedirectToAction(nameof(Album), "Albums", new { id = model.Id });
        }

        public IActionResult Index(string id)
        {
            return View(albums.GetAllAlbums(id));
        }

        public IActionResult SetAsAlbumPhoto(int photoId, int albumId)
        {
            if (albums.UserIsOwner(albumId, User.Identity.Name))
            {
                albums.SetAlbumPicture(photoId, albumId);
                return RedirectToAction(nameof(Album), "Albums", new { id = albumId });
            }
            else
            {
                return View(nameof(NotFound));
            }
        }
    }
}
