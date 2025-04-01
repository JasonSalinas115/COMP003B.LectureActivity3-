using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity3_.Controllers
{
    [Route("store")]
    public class StoreController : Controller
    {
        [Route("product/{id:int}")]
        public IActionResult ViewProduct(int id)
        {
            return View(id);
        }

        [HttpGet("product/search")]
        public IActionResult Search([FromQuery] string cateogry)
        {
            return View("Search", cateogry);
        }
    }
}
