using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.DataSystem;
using System.Security;
using IPermission = GarageManagementSoftware.Models.Interface.DataSystem.IPermission;

namespace GarageManagementSoftware.Models.Service.DataSystem
{
    public class ActionForUserSerivce : DataSystemCommon, IActionForUser
    {
        public ActionForUserSerivce(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "ActionForUser"; }
        public StatusMessege<ActionForUserModel> Delete(HttpRequest httpRequest, ActionForUserModel model)
        {

            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.ActionForUserModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<ActionForUserModel> Get(HttpRequest httpRequest, ActionForUserModel model)
        {
            var row = this._dataContext.ActionForUserModel.Where(item =>
                string.IsNullOrEmpty(model.code) ? true : item.code == model.code
            ).ToList();
            return row;
        }

        public StatusMessege<ActionForUserModel> Insert(HttpRequest httpRequest, ActionForUserModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.ActionForUserModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<ActionForUserModel> Search(HttpRequest httpRequest, ActionForUserModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.ActionForUserModel.Where(item => item.code == model.code).FirstOrDefault();
                    if (row != null)
                    {
                        return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<ActionForUserModel> Update(HttpRequest httpRequest, ActionForUserModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.ActionForUserModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<ActionForUserModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
