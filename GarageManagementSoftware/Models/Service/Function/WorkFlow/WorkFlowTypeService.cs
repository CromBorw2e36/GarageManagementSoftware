﻿using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Service.Function.WorkFlow
{
    public class WorkFlowTypeService : DataSystemCommon, IWorkFlowType
    {
        public WorkFlowTypeService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }

        public StatusMessege<WorkFlowTypeModel> Delete(HttpRequest httpRequest, WorkFlowTypeModel model)
        {

            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.WorkFlowTypeModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<WorkFlowTypeModel> Get(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            var row = this._dataContext.WorkFlowTypeModel.Where(item =>
                string.IsNullOrEmpty(model.code) ? true : item.code == model.code
            ).ToList();
            return row;
        }

        public StatusMessege<WorkFlowTypeModel> Insert(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.WorkFlowTypeModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<WorkFlowTypeModel> Search(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.WorkFlowTypeModel.Where(item => item.code == model.code).FirstOrDefault();
                    if (row != null)
                    {
                        return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<WorkFlowTypeModel> Update(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.WorkFlowTypeModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<WorkFlowTypeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
