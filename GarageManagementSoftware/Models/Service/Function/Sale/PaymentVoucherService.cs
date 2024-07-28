using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
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
            throw new NotImplementedException();
        }

        public List<PaymentVoucherModel> Get(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<PaymentVoucherModel> Insert(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<PaymentVoucherModel> Search(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<PaymentVoucherModel> Update(HttpRequest httpRequest, PaymentVoucherModel model)
        {
            throw new NotImplementedException();
        }
    }
}
