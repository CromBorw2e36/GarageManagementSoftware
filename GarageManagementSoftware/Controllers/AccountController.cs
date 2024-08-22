using GarageManagementSoftware.Models;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Service.DataSystem;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GarageManagementSoftware.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;
        private readonly UserService _userService;
        public AccountController(DataContext dataContext)
        {
            this._accountService = new AccountService(dataContext);
            this._userService = new UserService(dataContext);
        }

        public ActionResult Index()
        {
            var listAccount = this._accountService.Get(this.HttpContext.Request, new AccountModel());
            var listUser = this._userService.Get(this.HttpContext.Request, new UserModel());
            ViewData["ACCOUNTS"] = listAccount;
            ViewData["USERS"] = listUser;
            return View();
        }

        public ActionResult Details(string codeUser, string companyCode)
        {
            ViewData["ACCOUNT"] = this._accountService.Search(HttpContext.Request, new AccountModel()
            {
                code = codeUser
            });

            ViewData["USER"] = this._userService.Search(HttpContext.Request, new UserModel()
            {
                code = codeUser,
            });

            return View("form");
        }

        [HttpPost]
        public ActionResult<StatusMessege<UserModel>> AddNewObject(AccountModel model)
        {
            AccountModel account = model.account!;
            UserModel user = model.user!;

            try
            {
                var resAccont = this._accountService.Insert(HttpContext.Request, account);
                var resUser = this._userService.Insert(HttpContext.Request, user);

                if (resAccont.status == 0 && resUser.status == 0)
                {
                    return resUser!;
                }
                else if (resAccont.status == 1)
                {
                    return new StatusMessege<UserModel>(resAccont.status, resAccont.messege, null)!;
                }
                else
                {
                    return resUser;
                }

            }
            catch
            {
                return new StatusMessege<UserModel>(1, "Xảy ra lỗi khi thêm nhân viên", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<UserModel>> UpdateObject(AccountModel model)
        {
            AccountModel account = model.account!;
            UserModel user = model.user!;

            try
            {
                var resAccont = this._accountService.Update(HttpContext.Request, account);
                var resUser = this._userService.Update(HttpContext.Request, user);

                if (resAccont.status == 0 && resUser.status == 0)
                {
                    return resUser!;
                }
                else if (resAccont.status == 1)
                {
                    return new StatusMessege<UserModel>(resAccont.status, resAccont.messege, null)!;
                }
                else
                {
                    return resUser;
                }

            }
            catch
            {
                return new StatusMessege<UserModel>(1, "Xảy ra lỗi khi cập nhật", null);
            }
        }

        [HttpPost]
        public ActionResult<StatusMessege<UserModel>> DeleteObject(AccountModel model)
        {
            AccountModel account = model.account!;
            UserModel user = model.user!;

            try
            {
                var resAccont = this._accountService.Delete(HttpContext.Request, account);
                var resUser = this._userService.Delete(HttpContext.Request, user);

                if (resAccont.status == 0 && resUser.status == 0)
                {
                    return resUser!;
                }
                else if (resAccont.status == 1)
                {
                    return new StatusMessege<UserModel>(resAccont.status, resAccont.messege, null)!;
                }
                else
                {
                    return resUser;
                }

            }
            catch
            {
                return new StatusMessege<UserModel>(1, "Xảy ra lỗi khi xóa", null);
            }
        }
    }
}
