using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Interface.DataSystem;

namespace GarageManagementSoftware.Models.Service.DataSystem
{
    public class UserService : DataSystemCommon, IUser
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<UserModel> Delete(HttpRequest httpRequest, UserModel model)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> Get(HttpRequest httpRequest, UserModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<UserModel> Insert(HttpRequest httpRequest, UserModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<UserModel> Search(HttpRequest httpRequest, UserModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<UserModel> Update(HttpRequest httpRequest, UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
