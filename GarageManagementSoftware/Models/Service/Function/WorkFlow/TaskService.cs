using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Service.Function.WorkFlow
{
    public class TaskService : DataSystemCommon, ITask
    {
        public TaskService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "Task"; }
        public StatusMessege<TaskModel> Delete(HttpRequest httpRequest, TaskModel model)
        {

            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.TaskModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<TaskModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<TaskModel> Get(HttpRequest httpRequest, TaskModel model)
        {
            var row = this._dataContext.TaskModel.Where(item =>
                string.IsNullOrEmpty(model.code) ? true : item.code == model.code
            ).ToList();
            return row;
        }

        public StatusMessege<TaskModel> Insert(HttpRequest httpRequest, TaskModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.TaskModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<TaskModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<TaskModel> Search(HttpRequest httpRequest, TaskModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.TaskModel.Where(item => item.code == model.code).FirstOrDefault();
                    if (row != null)
                    {
                        if (!string.IsNullOrEmpty(model.employee_code))
                        {
                            try
                            {

                                row.employee = this._dataContext.EmployeeModel.Where(x => x.code == model.employee_code).FirstOrDefault();
                            }
                            catch { }
                        }

                        if (!string.IsNullOrEmpty(model.project_code))
                        {
                            try
                            {

                                row.project = this._dataContext.ProjectModel.Where(x => x.code == model.project_code).FirstOrDefault();
                            }
                            catch { }
                        }

                        if (!string.IsNullOrEmpty(model.type_code))
                        {
                            try
                            {

                                row.type = this._dataContext.WorkFlowTypeModel.Where(x => x.code == model.type_code).FirstOrDefault();
                            }
                            catch { }
                        }

                        if (!string.IsNullOrEmpty(model.status_code))
                        {
                            try
                            {

                                row.status = this._dataContext.WorkFlowStatusModel.Where(x => x.code == model.status_code).FirstOrDefault();
                            }
                            catch { }
                        }
                        if (!string.IsNullOrEmpty(model.company_code))
                        {
                            try
                            {

                                row.company = this._dataContext.CompanyModel.Where(x => x.code == model.company_code).FirstOrDefault();
                            }
                            catch { }
                        }
                        return new StatusMessege<TaskModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<TaskModel> Update(HttpRequest httpRequest, TaskModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.TaskModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<TaskModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<TaskModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
