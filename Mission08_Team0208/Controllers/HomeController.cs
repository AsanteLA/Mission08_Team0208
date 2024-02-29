using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0208.Models;
using System.Diagnostics;

namespace Mission08_Team0208.Controllers
{
    public class HomeController : Controller
    {
        private IMatrixRepository _repo;
        public HomeController(IMatrixRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddOrEdit()
        {
            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            ViewBag.Quadrants = _repo.Quadrants
                .OrderBy(x => x.QuadrantId)
                .ToList();

            return View();
        }

    }
}
