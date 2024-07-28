using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;

namespace GarageManagementSoftware.Models.Interface.Function.Sale
{
    public interface IPaymentVoucher
    {
        public string tableName { get => this.tableName; set => this.tableName = "PaymentVoucher"; }
        public List<PaymentVoucherModel> Get(HttpRequest httpRequest, PaymentVoucherModel model);
        public StatusMessege<PaymentVoucherModel> Insert(HttpRequest httpRequest, PaymentVoucherModel model);
        public StatusMessege<PaymentVoucherModel> Update(HttpRequest httpRequest, PaymentVoucherModel model);
        public StatusMessege<PaymentVoucherModel> Delete(HttpRequest httpRequest, PaymentVoucherModel model);
        public StatusMessege<PaymentVoucherModel> Search(HttpRequest httpRequest, PaymentVoucherModel model);
    }
}
