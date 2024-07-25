using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Interface.DataSystem;
using System.Security;
using IPermission = GarageManagementSoftware.Models.Interface.DataSystem.IPermission;

namespace GarageManagementSoftware.Models.Service.DataSystem
{
    public class PermissionService : DataSystemCommon, IPermission
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<PermissionModel> Delete(HttpRequest httpRequest, PermissionModel model)
        {
            throw new NotImplementedException();
        }

        public List<PermissionModel> Get(HttpRequest httpRequest, PermissionModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<PermissionModel> Insert(HttpRequest httpRequest, PermissionModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<PermissionModel> Search(HttpRequest httpRequest, PermissionModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<PermissionModel> Update(HttpRequest httpRequest, PermissionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
