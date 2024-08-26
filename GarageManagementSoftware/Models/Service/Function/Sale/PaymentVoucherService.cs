using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.Sale;

namespace GarageManagementSoftware.Models.Service.Function.Sale
{
    public class PaymentVoucherSerivce : DataSystemCommon, IPaymentVoucher
    {
        public PaymentVoucherSerivce(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "PaymentVoucher"; }
        public StatusMessege<PaymentVoucherModel> Delete(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.PaymentVoucherModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<PaymentVoucherModel> Get(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            var row = this._dataContext.PaymentVoucherModel.Where(item =>
                 string.IsNullOrEmpty(model.code) ? true : item.code == model.code
             ).OrderByDescending(x => x.create_at).ToList();
            return row;
        }

        public StatusMessege<PaymentVoucherModel> Insert(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode(EnumTypeVoucher.PAYMENT);
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.PaymentVoucherModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<PaymentVoucherModel> Search(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.PaymentVoucherModel.Where(item => item.code == model.code).FirstOrDefault();
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

                        row.detail = this._dataContext.PaymentVoucherDetailModel.Where(x => x.paymentVoucher_code == model.code).ToList();

                        if (!string.IsNullOrEmpty(model.company_code))
                        {
                            try
                            {

                                row.company = this._dataContext.CompanyModel.Where(x => x.code == model.company_code).FirstOrDefault();
                            }
                            catch { }
                        }
                        return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<PaymentVoucherModel> Update(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.PaymentVoucherModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<PaymentVoucherModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
