using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GarageManagementSoftware.Controllers
{
    public class AdminstratorController : Controller
    {
        // GET: AdminstratorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminstratorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminstratorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminstratorController/Create
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

        // GET: AdminstratorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminstratorController/Edit/5
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

        // GET: AdminstratorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminstratorController/Delete/5
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
