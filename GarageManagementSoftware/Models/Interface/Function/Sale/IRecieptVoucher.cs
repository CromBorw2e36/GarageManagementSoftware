using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;

namespace GarageManagementSoftware.Models.Interface.Function.Sale
{
    public interface IRecieptVoucher
    {
        public string tableName { get; set; }
        public List<RecieptVoucherModel> Get(HttpRequest httpRequest, RecieptVoucherModel model);
        public StatusMessege<RecieptVoucherModel> Insert(HttpRequest httpRequest, RecieptVoucherModel model);
        public StatusMessege<RecieptVoucherModel> Update(HttpRequest httpRequest, RecieptVoucherModel model);
        public StatusMessege<RecieptVoucherModel> Delete(HttpRequest httpRequest, RecieptVoucherModel model);
        public StatusMessege<RecieptVoucherModel> Search(HttpRequest httpRequest, RecieptVoucherModel model);
    }
}
