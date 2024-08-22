using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Service.DataSystem;
using GarageManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;
using GarageManagementSoftware.Models.Service.Function.Employee;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using GarageManagementSoftware.Models.Service.Function.GarageAccess;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;
using GarageManagementSoftware.Models.Service.Function.Sale;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.Service.Function.WorkFlow;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;

namespace GarageManagementSoftware.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService _servicer;
        private readonly string endPoint = "task";
        private readonly string Title = "Công việc";
        public TaskController(DataContext dataContext)
        {
            this._servicer = new TaskService(dataContext);
        }

        public ActionResult Index()
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Get(HttpContext.Request, new TaskModel());
            return View();
        }

        public ActionResult Details(TaskModel model)
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Search(HttpContext.Request, model);
            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<TaskModel>> AddNewObject(TaskModel model)
        {
            try
            {
                var res = this._servicer.Insert(HttpContext.Request, model);

                return res;

            }
            catch
            {
                return new StatusMessege<TaskModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<TaskModel>> UpdateObject(TaskModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<TaskModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<TaskModel>> DeleteObject(TaskModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<TaskModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}