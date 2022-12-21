using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projek_ASP.Controllers
{
    public class HairdresserController : Controller
    {
        // GET: HairdresserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HairdresserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HairdresserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HairdresserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HairdresserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HairdresserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HairdresserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HairdresserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
