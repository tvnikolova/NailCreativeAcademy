using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NailCreativeAcademy.Core.Contracts;
using NailCreativeAcademy.Core.Models.Course;
using NailCreativeAcademy.Core.Models.Gallery;
using NailCreativeAcademy.Core.Models.Saloon;
using NailCreativeAcademy.Core.Services;
using System.Security.Claims;

namespace NailCreativeAcademy.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly IGalleryService galleryService;
        private readonly string rootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//gallery");
        public GalleryController(IGalleryService _galleryService)
        {
            this.galleryService = _galleryService;   
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<GalleryViewModel> saloons = await galleryService.AllAsync();

            return View(saloons);
        }

        
        [HttpPost]
        public async Task<IActionResult> Add(IFormFile file)
        {
            if (file == null)
            {
                return BadRequest();
            }
            string imageName = Guid.NewGuid() + Path.GetExtension(file.FileName);

            var path = Path.Combine(rootPath, imageName);

            using (var streamFile = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(streamFile);
            }
            

            GalleryFormModel formModel = new GalleryFormModel()
            {
                Name = imageName,
            };

            if (!ModelState.IsValid)
            {
                return View(formModel);
            }
            var gallery = await galleryService.AllAsync();

            if (gallery != null && gallery.Any(s => s.Name == formModel.Name))
            {
                ModelState.AddModelError(nameof(formModel.Name), $"Изображение с посоченото име вече съществува!");
            }
           

            await galleryService.AddImageAsync(formModel);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var imageToDelete = await galleryService.GetGalleryViewModelAsync(id);

            if (imageToDelete == null)
            {
                return BadRequest();
            }

            return View(imageToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            if (await galleryService.GetGalleryViewModelAsync(id) == null)
            {
                return BadRequest();
            }

            await galleryService.DeleteAsync(id);

            return RedirectToAction(nameof(All));
        }
    }
}
