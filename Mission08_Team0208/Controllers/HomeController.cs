using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0208.Models;
using SQLitePCL;
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

            return View("AddOrEdit", new TaskInfo());
        }

        [HttpPost]
        public IActionResult AddOrEdit(TaskInfo response)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

                ViewBag.Quadrants = _repo.Quadrants
                    .OrderBy(x => x.QuadrantId)
                    .ToList();

                _repo.AddTask(response);
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

                ViewBag.Quadrants = _repo.Quadrants
                    .OrderBy(x => x.QuadrantId)
                    .ToList();

                return View(response);
            }

        }

        public IActionResult Quadrant()
        {
            var Tasks = _repo.Tasks
                .OrderBy(x => x.TaskId)
                .ToList();

            return View(Tasks);
        }

        public IActionResult QTest()
        {
            var Tasks = _repo.Tasks
                .OrderBy(x => x.TaskId)
                .ToList();

            return View(Tasks);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var RecordToEdit = _repo.Tasks
                .Single(x => x.TaskId == id);

            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            ViewBag.Quadrants = _repo.Quadrants
                .OrderBy(x => x.QuadrantId)
                .ToList();

            return View("AddOrEdit", RecordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(TaskInfo UpdatedInfo)
        {
            _repo.Edit(UpdatedInfo);
            return RedirectToAction("QTest");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var RecordToDelete = _repo.Tasks
                .Single(x => x.TaskId == id);

            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            ViewBag.Quadrants = _repo.Quadrants
                .OrderBy(x => x.QuadrantId)
                .ToList();

            return View("Delete", RecordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(TaskInfo Delete)
        {
            _repo.Delete(Delete);

            return RedirectToAction("QTest");
        }
    }
}
