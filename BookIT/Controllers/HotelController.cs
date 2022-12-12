using BookIT.Core.Models.Hotel;
using Microsoft.AspNetCore.Mvc;

namespace BookIT.Controllers
{
    public class HotelController : Controller
    {
        public async Task<IActionResult>All()
        {
            var model = new HotelViewModel();

             return View(model);
        }
    }
}
