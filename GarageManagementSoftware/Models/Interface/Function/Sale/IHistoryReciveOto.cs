using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;

namespace GarageManagementSoftware.Models.Interface.Function.Sale
{
    public interface IHistoryReciveOto
    {
        public string tableName { get; set; }
        public List<HistoryReciveOtoModel> Get(HttpRequest httpRequest, HistoryReciveOtoModel model);
        public StatusMessege<HistoryReciveOtoModel> Insert(HttpRequest httpRequest, HistoryReciveOtoModel model);
        public StatusMessege<HistoryReciveOtoModel> Update(HttpRequest httpRequest, HistoryReciveOtoModel model);
        public StatusMessege<HistoryReciveOtoModel> Delete(HttpRequest httpRequest, HistoryReciveOtoModel model);
        public StatusMessege<HistoryReciveOtoModel> Search(HttpRequest httpRequest, HistoryReciveOtoModel model);
    }
}
