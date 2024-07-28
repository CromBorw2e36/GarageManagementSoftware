using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.Employee;

namespace GarageManagementSoftware.Models.Service.Function.Employee
{
    public class EmployeeStatusService : DataSystemCommon, IEmployeeStatus
    {
        public EmployeeStatusService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "EmployeeStatus"; }
        public StatusMessege<EmployeeStatusModel> Delete(HttpRequest httpRequest, EmployeeStatusModel model)
{

    if (string.IsNullOrEmpty(model.code))
    {
        return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
    }
    else
    {
        var row = this._dataContext.EmployeeStatusModel.Where(item => item.code == model.code).FirstOrDefault();
        if (row != null)
        {
            row.is_delete = true;
            row.delete_at = DateTime.Now;
            this._dataContext.Update(row);
            this._dataContext.SaveChanges();
            return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
        }
        else
        {
            return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
        }
    }
}

public List<EmployeeStatusModel> Get(HttpRequest httpRequest, EmployeeStatusModel model)
{
    var row = this._dataContext.EmployeeStatusModel.Where(item =>
        string.IsNullOrEmpty(model.code) ? true : item.code == model.code
    ).ToList();
    return row;
}

public StatusMessege<EmployeeStatusModel> Insert(HttpRequest httpRequest, EmployeeStatusModel model)
{
    if (string.IsNullOrEmpty(model.code))
    {
        return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
    }
    else
    {
        try
        {
            model.code = this.GenRowCode();
            model.create_at = DateTime.Now;
            model.update_at = DateTime.Now;
            this._dataContext.EmployeeStatusModel.Add(model);
            this._dataContext.SaveChanges();
            return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
        }
        catch
        {
            return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
        }
    }
}

public StatusMessege<EmployeeStatusModel> Search(HttpRequest httpRequest, EmployeeStatusModel model)
{
    if (string.IsNullOrEmpty(model.code))
    {
        return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
    }
    else
    {
        try
        {
            var row = this._dataContext.EmployeeStatusModel.Where(item => item.code == model.code).FirstOrDefault();
            if (row != null)
            {
                return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
            }
            else
            {
                return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
            }
        }
        catch
        {
            return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
        }
    }
}

public StatusMessege<EmployeeStatusModel> Update(HttpRequest httpRequest, EmployeeStatusModel model)
{
    if (string.IsNullOrEmpty(model.code))
    {
        return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
    }
    else
    {
        var row = this._dataContext.EmployeeStatusModel.Where(item => item.code == model.code).FirstOrDefault();
        if (row != null)
        {
            try
            {
                row = model;
                row.update_at = DateTime.Now;
                this._dataContext.Update(row);
                this._dataContext.SaveChanges();
                return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
            }
            catch
            {
                return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
            }
        }
        else
        {
            return new StatusMessege<EmployeeStatusModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
        }
    }
}
    }
}
