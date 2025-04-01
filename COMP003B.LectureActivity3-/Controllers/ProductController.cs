using Microsoft.AspNetCore.Mvc;
using COMP003B.LectureActivity3-.Models;

namespace COMP003B.LectureActivity3_.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create([FromForm] Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            return RedirectToAction("Success", product);
        }

        [Route("success")]
        public IActionResult success(Product product)
        {
            return View(product);
        }
    }
}
