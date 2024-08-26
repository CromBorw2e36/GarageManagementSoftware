using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.GarageAccess;
using GarageManagementSoftware.Models.Interface.Function.Sale;

namespace GarageManagementSoftware.Models.Service.Function.Sale
{
    public class HistoryReviceOtoService : DataSystemCommon, IHistoryReciveOto
    {
        public HistoryReviceOtoService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "HistoryReciveOto"; }
        public StatusMessege<HistoryReciveOtoModel> Delete(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {

            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.HistoryReciveOtoModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<HistoryReciveOtoModel> Get(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            var row = this._dataContext.HistoryReciveOtoModel.Where(item =>
                string.IsNullOrEmpty(model.code) ? true : item.code == model.code
            ).ToList();
            return row;
        }

        public StatusMessege<HistoryReciveOtoModel> Insert(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode(EnumTypeVoucher.VOUCHER_1);
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.HistoryReciveOtoModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<HistoryReciveOtoModel> Search(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.HistoryReciveOtoModel.Where(item => item.code == model.code).FirstOrDefault();
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

                        if (!string.IsNullOrEmpty(model.customer_code))
                        {
                            try
                            {

                                row.customer = this._dataContext.EmployeeModel.Where(x => x.code == model.employee_code).FirstOrDefault();
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
                        return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<HistoryReciveOtoModel> Update(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.HistoryReciveOtoModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<HistoryReciveOtoModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
