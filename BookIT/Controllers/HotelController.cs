using BookIT.Core.Models.Hotel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookIT.Controllers
{
    [Authorize]
    public class HotelController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult>All()
        {
            var model = new HotelViewModel();

             return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = new HotelDetailsViewModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(HotelViewModel model)
        {
            int id = 1;

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new HotelViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, HotelViewModel model)
        {
            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            return RedirectToAction(nameof(All));
        }
    }
}
