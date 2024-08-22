using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Service.DataSystem;
using GarageManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarageManagementSoftware.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanySerivce _companySerivce;
        private readonly string endPoint = "thong-tin-cong-ty";
        private readonly string Title = "Công ty";
        public CompanyController(DataContext dataContext)
        {
            this._companySerivce = new CompanySerivce(dataContext);
        }

        public ActionResult Index()
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._companySerivce.Get(HttpContext.Request, new CompanyModel());
            return View();
        }

        public ActionResult Details(CompanyModel model)
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._companySerivce.Search(HttpContext.Request, model);
            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<CompanyModel>> AddNewObject(CompanyModel model)
        {
            try
            {
                var res = this._companySerivce.Insert(HttpContext.Request, model);

                return res;

            }
            catch
            {
                return new StatusMessege<CompanyModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<CompanyModel>> UpdateObject(CompanyModel model)
        {

            try
            {
                var res = this._companySerivce.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<CompanyModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<CompanyModel>> DeleteObject(CompanyModel model)
        {

            try
            {
                var res = this._companySerivce.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<CompanyModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}
