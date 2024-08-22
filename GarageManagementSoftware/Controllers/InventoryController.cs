using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Service.DataSystem;
using GarageManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;
using GarageManagementSoftware.Models.Service.Function.Employee;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using GarageManagementSoftware.Models.Service.Function.GarageAccess;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;

namespace GarageManagementSoftware.Controllers
{
    public class InventoryController : Controller
    {
        private readonly InventoryService _servicer;
        private readonly string endPoint = "kho";
        private readonly string Title = "Kho";
        public InventoryController(DataContext dataContext)
        {
            this._servicer = new InventoryService(dataContext);
        }

        public ActionResult Index()
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Get(HttpContext.Request, new InventoryModel());
            return View();
        }

        public ActionResult Details(InventoryModel model)
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Search(HttpContext.Request, model);
            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<InventoryModel>> AddNewObject(InventoryModel model)
        {
            try
            {
                var res = this._servicer.Insert(HttpContext.Request, model);

                return res;

            }
            catch
            {
                return new StatusMessege<InventoryModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<InventoryModel>> UpdateObject(InventoryModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<InventoryModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<InventoryModel>> DeleteObject(InventoryModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<InventoryModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}