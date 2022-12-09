using BookIT.Core.Models.Hotel;
using Microsoft.AspNetCore.Mvc;

namespace BookIT.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult All()
        {
            var model = new AllHotelsQueryModel();

                return View(model);
        }
    }
}
