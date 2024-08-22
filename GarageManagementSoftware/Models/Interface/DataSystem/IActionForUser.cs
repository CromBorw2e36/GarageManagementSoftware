using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;

namespace GarageManagementSoftware.Models.Interface.DataSystem
{
    public interface IActionForUser
    {
        public string tableName { get => this.tableName; set => this.tableName = "ActionForUser"; }
        public List<ActionForUserModel> Get(HttpRequest httpRequest, ActionForUserModel model);
        public StatusMessege<ActionForUserModel> Insert(HttpRequest httpRequest, ActionForUserModel model);
        public StatusMessege<ActionForUserModel> Update(HttpRequest httpRequest, ActionForUserModel model);
        public StatusMessege<ActionForUserModel> Delete(HttpRequest httpRequest, ActionForUserModel model);
        public StatusMessege<ActionForUserModel> Search(HttpRequest httpRequest, ActionForUserModel model);
    }
}
