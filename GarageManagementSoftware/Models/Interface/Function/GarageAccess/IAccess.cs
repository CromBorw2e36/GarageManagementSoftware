using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;

namespace GarageManagementSoftware.Models.Interface.Function.GarageAccess
{
    public interface IAccess
    {
        public string tableName { get => this.tableName; set => this.tableName = "Access"; }
        public List<AccessModel> Get(HttpRequest httpRequest, AccessModel model);
        public StatusMessege<AccessModel> Insert(HttpRequest httpRequest, AccessModel model);
        public StatusMessege<AccessModel> Update(HttpRequest httpRequest, AccessModel model);
        public StatusMessege<AccessModel> Delete(HttpRequest httpRequest, AccessModel model);
        public StatusMessege<AccessModel> Search(HttpRequest httpRequest, AccessModel model);
    }
}
