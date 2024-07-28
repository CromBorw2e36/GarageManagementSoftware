using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;

namespace GarageManagementSoftware.Models.Interface.DataSystem
{
    public interface IPermission
    {
        public string tableName { get => this.tableName; set => this.tableName = "Permission"; }
        public List<PermissionModel> Get(HttpRequest httpRequest, PermissionModel model);
        public StatusMessege<PermissionModel> Insert(HttpRequest httpRequest, PermissionModel model);
        public StatusMessege<PermissionModel> Update(HttpRequest httpRequest, PermissionModel model);
        public StatusMessege<PermissionModel> Delete(HttpRequest httpRequest, PermissionModel model);
        public StatusMessege<PermissionModel> Search(HttpRequest httpRequest, PermissionModel model);
    }
}
