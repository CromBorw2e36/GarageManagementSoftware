using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Service.DataSystem;
using GarageManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarageManagementSoftware.Controllers
{
    public class PermissionController : Controller
    {
        private readonly PermissionService permissionService;
        private readonly string endPoint = "thong-tin-phan-quyen";
        private readonly string Title = "Phân quyền";
        public PermissionController(DataContext dataContext)
        {
            this.permissionService = new PermissionService(dataContext);
        }

        public ActionResult Index()
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this.permissionService.Get(HttpContext.Request, new PermissionModel());
            return View();
        }

        public ActionResult Details(PermissionModel model)
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this.permissionService.Search(HttpContext.Request, model);
            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<PermissionModel>> AddNewObject(PermissionModel model)
        {
            try
            {
                var res = this.permissionService.Insert(HttpContext.Request, model);

                return res;

            }
            catch
            {
                return new StatusMessege<PermissionModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<PermissionModel>> UpdateObject(PermissionModel model)
        {

            try
            {
                var res = this.permissionService.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<PermissionModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<PermissionModel>> DeleteObject(PermissionModel model)
        {

            try
            {
                var res = this.permissionService.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<PermissionModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}