using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.Sale;

namespace GarageManagementSoftware.Models.Service.Function.Sale
{
    public class RecieptVoucherService : DataSystemCommon, IRecieptVoucher
    {
        public RecieptVoucherService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "RecieptVoucher"; }
        public StatusMessege<RecieptVoucherModel> Delete(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.RecieptVoucherModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<RecieptVoucherModel> Get(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            var row = this._dataContext.RecieptVoucherModel.Where(item =>
                 string.IsNullOrEmpty(model.code) ? true : item.code == model.code
             ).OrderByDescending(x => x.create_at).ToList();
            return row;
        }

        public StatusMessege<RecieptVoucherModel> Insert(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.RecieptVoucherModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<RecieptVoucherModel> Search(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.RecieptVoucherModel.Where(item => item.code == model.code).FirstOrDefault();
                    if (row != null)
                    {
                        if (!string.IsNullOrEmpty(model.historyReviceOto_code))
                        {
                            try
                            {

                                row.historyReviceOto = this._dataContext.HistoryReciveOtoModel.Where(x => x.code == model.historyReviceOto_code).FirstOrDefault();
                            }
                            catch { }
                        }

                        row.detail = this._dataContext.RecieptVoucherDetailModel.Where(x => x.recieptVoucher_code == model.code).ToList();

                        if (!string.IsNullOrEmpty(model.company_code))
                        {
                            try
                            {

                                row.company = this._dataContext.CompanyModel.Where(x => x.code == model.company_code).FirstOrDefault();
                            }
                            catch { }
                        }
                        return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<RecieptVoucherModel> Update(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.RecieptVoucherModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<RecieptVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
