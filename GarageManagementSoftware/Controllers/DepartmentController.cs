using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Service.DataSystem;
using GarageManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;
using GarageManagementSoftware.Models.Service.Function.Employee;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;

namespace GarageManagementSoftware.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentService _servicer;
        private readonly string endPoint = "phongban";
        private readonly string Title = "Phòng ban";
        public DepartmentController(DataContext dataContext)
        {
            this._servicer = new DepartmentService(dataContext);
        }

        public ActionResult Index()
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Get(HttpContext.Request, new DepartmentModel());
            return View();
        }

        public ActionResult Details(DepartmentModel model)
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Search(HttpContext.Request, model);
            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<DepartmentModel>> AddNewObject(DepartmentModel model)
        {
            try
            {
                var res = this._servicer.Insert(HttpContext.Request, model);

                return res;

            }
            catch
            {
                return new StatusMessege<DepartmentModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<DepartmentModel>> UpdateObject(DepartmentModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<DepartmentModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<DepartmentModel>> DeleteObject(DepartmentModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<DepartmentModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}