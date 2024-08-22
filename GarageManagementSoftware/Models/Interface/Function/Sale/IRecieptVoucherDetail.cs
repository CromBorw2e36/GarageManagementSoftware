using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;

namespace GarageManagementSoftware.Models.Interface.Function.Sale
{
    public interface IRecieptVoucherDetail
    {
        public string tableName { get => this.tableName; set => this.tableName = "RecieptVoucherDetail"; }
        public List<RecieptVoucherDetailModel> Get(HttpRequest httpRequest, RecieptVoucherDetailModel model);
        public StatusMessege<RecieptVoucherDetailModel> Insert(HttpRequest httpRequest, RecieptVoucherDetailModel model);
        public StatusMessege<RecieptVoucherDetailModel> InsertList(HttpRequest httpRequest, List<RecieptVoucherDetailModel> model);
        public StatusMessege<RecieptVoucherDetailModel> Update(HttpRequest httpRequest, RecieptVoucherDetailModel model);
        public StatusMessege<RecieptVoucherDetailModel> Delete(HttpRequest httpRequest, RecieptVoucherDetailModel model);
        public StatusMessege<RecieptVoucherDetailModel> Search(HttpRequest httpRequest, RecieptVoucherDetailModel model);
    }
}
