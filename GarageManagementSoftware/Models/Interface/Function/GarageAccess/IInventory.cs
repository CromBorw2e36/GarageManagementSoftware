using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;

namespace GarageManagementSoftware.Models.Interface.Function.GarageAccess
{
    public interface IInventory
    {
        public string tableName { get => this.tableName; set => this.tableName = "Inventory"; }
        public List<InventoryModel> Get(HttpRequest httpRequest, InventoryModel model);
        public StatusMessege<InventoryModel> Insert(HttpRequest httpRequest, InventoryModel model);
        public StatusMessege<InventoryModel> Update(HttpRequest httpRequest, InventoryModel model);
        public StatusMessege<InventoryModel> Delete(HttpRequest httpRequest, InventoryModel model);
        public StatusMessege<InventoryModel> Search(HttpRequest httpRequest, InventoryModel model);
    }
}
