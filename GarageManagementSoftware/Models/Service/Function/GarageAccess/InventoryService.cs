using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;
using GarageManagementSoftware.Models.Interface.Function.GarageAccess;

namespace GarageManagementSoftware.Models.Service.Function.GarageAccess
{
    public class InventoryService : DataSystemCommon, IInventory
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<InventoryModel> Delete(HttpRequest httpRequest, InventoryModel model)
        {
            throw new NotImplementedException();
        }

        public List<InventoryModel> Get(HttpRequest httpRequest, InventoryModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<InventoryModel> Insert(HttpRequest httpRequest, InventoryModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<InventoryModel> Search(HttpRequest httpRequest, InventoryModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<InventoryModel> Update(HttpRequest httpRequest, InventoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
