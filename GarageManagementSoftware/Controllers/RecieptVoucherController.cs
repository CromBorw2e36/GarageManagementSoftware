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

namespace GarageManagementSoftware.Controllers
{
    public class RecieptVoucherController : Controller
    {
        private readonly RecieptVoucherService _servicer;
        private readonly string endPoint = "recieptvoucher";
        private readonly string Title = "Phiếu thu";
        public RecieptVoucherController(DataContext dataContext)
        {
            this._servicer = new RecieptVoucherService(dataContext);
        }

        public ActionResult Index()
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Get(HttpContext.Request, new RecieptVoucherModel());
            return View();
        }

        public ActionResult Details(RecieptVoucherModel model)
        {
            ViewData["Titlte"] = this.Title;
            ViewData["EndPoint"] = this.endPoint;
            ViewData["INPUTMASTER"] = this._servicer.Search(HttpContext.Request, model);
            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<RecieptVoucherModel>> AddNewObject(RecieptVoucherModel model)
        {
            try
            {
                var res = this._servicer.Insert(HttpContext.Request, model);

                return res;

            }
            catch
            {
                return new StatusMessege<RecieptVoucherModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<RecieptVoucherModel>> UpdateObject(RecieptVoucherModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<RecieptVoucherModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<RecieptVoucherModel>> DeleteObject(RecieptVoucherModel model)
        {

            try
            {
                var res = this._servicer.Update(HttpContext.Request, model);
                return res;
            }
            catch
            {
                return new StatusMessege<RecieptVoucherModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}