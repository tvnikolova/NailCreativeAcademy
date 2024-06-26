﻿namespace NailCreativeAcademy.Controllers
{
    using Core.Contracts;
    using Core.Models.Saloon;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    public class SaloonController : BaseController
    {
        private readonly ISaloonService saloonService;
        public SaloonController(ISaloonService _saloonService)
        {
            this.saloonService = _saloonService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<SaloonViewModel> saloons = await saloonService.AllAsync();

            return View(saloons);
        }

        [HttpGet]
        public IActionResult Add()
        {
           SaloonFormModel newSaloon =  new SaloonFormModel();

            return View(newSaloon);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SaloonFormModel newSaloon)
        {

            if(!ModelState.IsValid)
            {
                return View(newSaloon);
            }
            string userId = User.GetUserId();
            var allSaloon = await saloonService.AllAsync();

            if(allSaloon != null && allSaloon.Any(s=>s.Address == newSaloon.Address))
            {
                return BadRequest();
            }
			if (allSaloon != null && allSaloon.Any(s => s.PhoneNumber == newSaloon.PhoneNumber))
			{
				return BadRequest();
			}
            newSaloon.ClientId = userId;

            await saloonService.AddAsync(newSaloon);

            return RedirectToAction(nameof(All));
		}
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
          var foundSaloon = await saloonService.GetSaloonFormByIdAsync(id);

            if(foundSaloon == null)
            {
                return BadRequest();
            }

            return View(foundSaloon);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(SaloonFormModel saloon, int id)
        {
            var foundSaloon = await saloonService.GetSaloonFormByIdAsync(id);

            if (foundSaloon == null)
            {
                return BadRequest();
            }

            await saloonService.EditAsync(saloon, id);

            return RedirectToAction(nameof(All));
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await saloonService.DetailsAsync(id);

            return View(model);
        }

        [HttpGet]
       public async Task<IActionResult> Delete(int id)
        {
            var saloonToDelete = await saloonService.GetSaloonViewModelAsync(id);

            if(saloonToDelete == null)
            {
                return BadRequest();
            }

            return View(saloonToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            if (await saloonService.GetSaloonFormByIdAsync(id) == null)
            {
                return BadRequest();
            }

            await saloonService.DeleteAsync(id);

            return RedirectToAction(nameof(All));
        }
    }
}
