using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.Sale;

namespace GarageManagementSoftware.Models.Service.Function.Sale
{
    public class PaymentVoucherDetailService : DataSystemCommon, IPaymentVoucherDetail
    {
        public PaymentVoucherDetailService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "PaymentVoucherDetail"; }
        public StatusMessege<PaymentVoucherDetailModel> Delete(HttpRequest httpRequest, PaymentVoucherDetailModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.PaymentVoucherDetailModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<PaymentVoucherDetailModel> Get(HttpRequest httpRequest, PaymentVoucherDetailModel model)
        {
            var row = this._dataContext.PaymentVoucherDetailModel.Where(item =>
                 string.IsNullOrEmpty(model.code) ? true : item.code == model.code
             ).OrderByDescending(x => x.create_at).ToList();
            return row;
        }

        public StatusMessege<PaymentVoucherDetailModel> Insert(HttpRequest httpRequest, PaymentVoucherDetailModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.PaymentVoucherDetailModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<PaymentVoucherDetailModel> InsertList(HttpRequest httpRequest, List<PaymentVoucherDetailModel> model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<PaymentVoucherDetailModel> Search(HttpRequest httpRequest, PaymentVoucherDetailModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.PaymentVoucherDetailModel.Where(item => item.code == model.code).FirstOrDefault();
                    if (row != null)
                    {
                        return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<PaymentVoucherDetailModel> Update(HttpRequest httpRequest, PaymentVoucherDetailModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.PaymentVoucherDetailModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<PaymentVoucherDetailModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
