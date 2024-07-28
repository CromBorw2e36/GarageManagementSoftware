using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.Employee;

namespace GarageManagementSoftware.Models.Service.Function.Employee
{
    public class EmployeeService : DataSystemCommon, IEmployee
    {
        public EmployeeService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "Employee"; }
        public StatusMessege<EmployeeModel> Delete(HttpRequest httpRequest,EmployeeModel model)
        {

            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.EmployeeModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<EmployeeModel> Get(HttpRequest httpRequest,EmployeeModel model)
        {
            var row = this._dataContext.EmployeeModel.Where(item =>
                string.IsNullOrEmpty(model.code) ? true : item.code == model.code
            ).ToList();
            return row;
        }

        public StatusMessege<EmployeeModel> Insert(HttpRequest httpRequest,EmployeeModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.EmployeeModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<EmployeeModel> Search(HttpRequest httpRequest,EmployeeModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.EmployeeModel.Where(item => item.code == model.code).FirstOrDefault();
                    if (row != null)
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(model.company_code))
                            {
                                row.company = this._dataContext.CompanyModel.Where(x => x.code == model.company_code).FirstOrDefault();
                            }
                        }   
                        catch { }
                        return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<EmployeeModel> Update(HttpRequest httpRequest,EmployeeModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.EmployeeModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<EmployeeModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
