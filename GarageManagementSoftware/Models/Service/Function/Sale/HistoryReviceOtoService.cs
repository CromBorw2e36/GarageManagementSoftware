using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.Interface.Function.GarageAccess;
using GarageManagementSoftware.Models.Interface.Function.Sale;

namespace GarageManagementSoftware.Models.Service.Function.Sale
{
    public class HistoryReviceOtoService : DataSystemCommon, IHistoryReciveOto
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<HistoryReciveOtoModel> Delete(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            throw new NotImplementedException();
        }

        public List<HistoryReciveOtoModel> Get(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<HistoryReciveOtoModel> Insert(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<HistoryReciveOtoModel> Search(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<HistoryReciveOtoModel> Update(HttpRequest httpRequest, HistoryReciveOtoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
