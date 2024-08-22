using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.DataSystem;

namespace GarageManagementSoftware.Models.Service.DataSystem
{
    public class AccountService : DataSystemCommon, IAccount
    {
        public string tableName { get => this.tableName; set => this.tableName = "Account"; }

        public AccountService(DataContext dataContext) : base(dataContext) { }


        public StatusMessege<AccountModel> Delete(HttpRequest httpRequest, AccountModel model)
        {

            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.AccountModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<AccountModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<AccountModel> Get(HttpRequest httpRequest, AccountModel model)
        {
            var row = this._dataContext.AccountModel.Where(item =>
                string.IsNullOrEmpty(model.code) ? true : item.code == model.code
                || (model.is_delete == null || model.is_delete == item.is_delete)

            ).ToList();
            return row;
        }

        public StatusMessege<AccountModel> Insert(HttpRequest httpRequest, AccountModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.AccountModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<AccountModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<AccountModel> Search(HttpRequest httpRequest, AccountModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.AccountModel.Where(item => item.code == model.code).FirstOrDefault();
                    if (row != null)
                    {
                        return new StatusMessege<AccountModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<AccountModel> Update(HttpRequest httpRequest, AccountModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.AccountModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<AccountModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<AccountModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
