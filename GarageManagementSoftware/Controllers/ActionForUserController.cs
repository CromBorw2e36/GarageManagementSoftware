using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Service.DataSystem;
using GarageManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarageManagementSoftware.Controllers
{
    public class ActionForUserController : Controller
    {
        private readonly ActionForUserSerivce actionForUserSerivce;
        private readonly string endPoint = "hanh-dong-cua-nguoi-dung";
        private readonly string Title = "Phân quyền";
        public ActionForUserController(DataContext dataContext)
        {
            this.actionForUserSerivce = new ActionForUserSerivce(dataContext);
        }

        public ActionResult Index()
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this.actionForUserSerivce.Get(HttpContext.Request, new ActionForUserModel());
            return View();
        }

        public ActionResult Details(ActionForUserModel model)
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this.actionForUserSerivce.Search(HttpContext.Request, model);
            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<ActionForUserModel>> AddNewObject(ActionForUserModel model)
        {
            try
            {
                var res = this.actionForUserSerivce.Insert(HttpContext.Request, model);

                return res;

            }
            catch
            {
                return new StatusMessege<ActionForUserModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<ActionForUserModel>> UpdateObject(ActionForUserModel model)
        {

            try
            {
                var res = this.actionForUserSerivce.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<ActionForUserModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<ActionForUserModel>> DeleteObject(ActionForUserModel model)
        {

            try
            {
                var res = this.actionForUserSerivce.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<ActionForUserModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}