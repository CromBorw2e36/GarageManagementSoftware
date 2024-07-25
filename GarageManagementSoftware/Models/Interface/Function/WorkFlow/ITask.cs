using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Interface.Function.WorkFlow
{
    public interface ITask
    {
        public string tableName { get; set; }
        public List<TaskModel> Get(HttpRequest httpRequest, TaskModel model);
        public StatusMessege<TaskModel> Insert(HttpRequest httpRequest, TaskModel model);
        public StatusMessege<TaskModel> Update(HttpRequest httpRequest, TaskModel model);
        public StatusMessege<TaskModel> Delete(HttpRequest httpRequest, TaskModel model);
        public StatusMessege<TaskModel> Search(HttpRequest httpRequest, TaskModel model);
    }
}
