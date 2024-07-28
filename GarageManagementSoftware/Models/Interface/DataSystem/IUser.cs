using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;

namespace GarageManagementSoftware.Models.Interface.DataSystem
{
    public interface IUser
    {
        public string tableName { get => this.tableName; set => this.tableName = "User"; }
        public List<UserModel> Get(HttpRequest httpRequest, UserModel model);
        public StatusMessege<UserModel> Insert(HttpRequest httpRequest, UserModel model);
        public StatusMessege<UserModel> Update(HttpRequest httpRequest, UserModel model);
        public StatusMessege<UserModel> Delete(HttpRequest httpRequest, UserModel model);
        public StatusMessege<UserModel> Search(HttpRequest httpRequest, UserModel model);
    }
}
