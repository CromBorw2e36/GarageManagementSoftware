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
    public class ProjectController : Controller
    {
        private readonly ProjectService _servicer;
        private readonly string endPoint = "project";
        private readonly string Title = "Dự án";
        public ProjectController(DataContext dataContext)
        {
            this._servicer = new ProjectService(dataContext);
        }

        public ActionResult Index()
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Get(HttpContext.Request, new ProjectModel());
            return View();
        }

        public ActionResult Details(ProjectModel model)
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Search(HttpContext.Request, model);
            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<ProjectModel>> AddNewObject(ProjectModel model)
        {
            try
            {
                var res = this._servicer.Insert(HttpContext.Request, model);

                return res;

            }
            catch
            {
                return new StatusMessege<ProjectModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<ProjectModel>> UpdateObject(ProjectModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<ProjectModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<ProjectModel>> DeleteObject(ProjectModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<ProjectModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}