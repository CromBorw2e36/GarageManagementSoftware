using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
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
            throw new NotImplementedException();
        }

        public List<RecieptVoucherModel> Get(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<RecieptVoucherModel> Insert(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<RecieptVoucherModel> Search(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<RecieptVoucherModel> Update(HttpRequest httpRequest, RecieptVoucherModel model)
        {
            throw new NotImplementedException();
        }
    }
}
