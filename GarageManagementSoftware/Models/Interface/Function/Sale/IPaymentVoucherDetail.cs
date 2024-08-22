using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;

namespace GarageManagementSoftware.Models.Interface.Function.Sale
{
    public interface IPaymentVoucherDetail
    {
        public string tableName { get => this.tableName; set => this.tableName = "PaymentVoucherDetail"; }
        public List<PaymentVoucherDetailModel> Get(HttpRequest httpRequest, PaymentVoucherDetailModel model);
        public StatusMessege<PaymentVoucherDetailModel> Insert(HttpRequest httpRequest, PaymentVoucherDetailModel model);
        public StatusMessege<PaymentVoucherDetailModel> InsertList(HttpRequest httpRequest, List<PaymentVoucherDetailModel> model);
        public StatusMessege<PaymentVoucherDetailModel> Update(HttpRequest httpRequest, PaymentVoucherDetailModel model);
        public StatusMessege<PaymentVoucherDetailModel> Delete(HttpRequest httpRequest, PaymentVoucherDetailModel model);
        public StatusMessege<PaymentVoucherDetailModel> Search(HttpRequest httpRequest, PaymentVoucherDetailModel model);
    }
}
