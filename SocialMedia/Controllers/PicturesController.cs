namespace SocialMedia.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SocialMedia.Common;
    using SocialMedia.Infrastructure;
    using SocialMedia.Services.Common.Interfaces;
    using SocialMedia.Services.Common.Models;
    using System.Linq;

    [Authorize]
    public class PicturesController : Controller
    {
        private readonly IPictureService pictures;

        private readonly IAlbumService albums;

        public PicturesController(IPictureService pictures, IAlbumService albums)
        {
            this.pictures = pictures;
            this.albums = albums;
        }

        public IActionResult Upload(string albumTitle, int albumId)
        {
            var allAlbums = pictures.GetAllAlbums(User.Identity.Name);
            return View(new UploadPicture
            {
                Albums = allAlbums.Select(s => new SelectListItem
                {
                    Text = albumTitle,
                    Value = albumTitle
                }),
                AlbumTitle = albumTitle,
                AlbumId = albumId

            });
        }

        [HttpPost]
        public IActionResult Upload(UploadPicture model)
        {
            var fileContents = model.Photo.ToByteArray();
            var albumId = 0;
            if (model.AlbumTitle != null && model.AlbumId == 0)
            {
                albumId = albums.CreateAlbum(model.AlbumTitle, User.Identity.Name);
            }
            else
            {
                albumId = model.AlbumId;
            }
            var success = pictures.CreatePicture(model.Description, fileContents, albumId);

            if (!success)
            {
                return Redirect("/NotFound");
            }

            return RedirectToAction("Album", "Albums", new { id = albumId });
        }

        public IActionResult Delete(int id)
        {
            if (pictures.UserIsOwner(id, User.Identity.Name) || User.IsInRole(GlobalConstants.AdministratorRole))
            {
                var pictureInfo = pictures.GetPictureInfo(id);
                return View(new DeletePicture { Id = id, Description = pictureInfo.Description, PublishDate = pictureInfo.PublishDate, AlbumName = pictureInfo.AlbumName });
            }
            else
            {
                return Redirect("/NotFound");
            }
        }

        [HttpPost]
        public IActionResult Destroy(int id)
        {
            var userId = pictures.GetUserId(id);
            pictures.DeletePicture(id);
            return RedirectToAction(nameof(Index), "Albums", new { id = userId });
        }

        public IActionResult Edit(int id)
        {
            if (pictures.UserIsOwner(id, User.Identity.Name) || User.IsInRole(GlobalConstants.AdministratorRole))
            {
                var pictureInfo = pictures.GetPictureInfo(id);
                return View(new EditPicture { Id = id, Description = pictureInfo.Description });
            }
            else
            {
                return Redirect("/NotFound");
            }
        }

        [HttpPost]
        public IActionResult Edit(EditPicture model)
        {
            pictures.EditPicture(model.Id, model.Description);

            return RedirectToAction(nameof(Index), "Pictures", new { id = model.Id });
        }

        public IActionResult Index(int id)
        {
            try
            {
                return View(pictures.GetPicture(id));
            }
            catch (System.Exception)
            {
                return Redirect("/NotFound");
            }
        }
    }
}
