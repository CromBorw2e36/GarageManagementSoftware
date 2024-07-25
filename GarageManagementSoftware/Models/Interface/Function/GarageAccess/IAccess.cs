using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;

namespace GarageManagementSoftware.Models.Interface.Function.GarageAccess
{
    public interface IAccess
    {
        public string tableName { get; set; }
        public List<AccountModel> Get(HttpRequest httpRequest, AccountModel model);
        public StatusMessege<AccountModel> Insert(HttpRequest httpRequest, AccountModel model);
        public StatusMessege<AccountModel> Update(HttpRequest httpRequest, AccountModel model);
        public StatusMessege<AccountModel> Delete(HttpRequest httpRequest, AccountModel model);
        public StatusMessege<AccountModel> Search(HttpRequest httpRequest, AccountModel model);
    }
}
