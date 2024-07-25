using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;
using GarageManagementSoftware.Models.Interface.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Service.Function.WorkFlow
{
    public class TaskService : DataSystemCommon, ITask
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<TaskModel> Delete(HttpRequest httpRequest, TaskModel model)
        {
            throw new NotImplementedException();
        }

        public List<TaskModel> Get(HttpRequest httpRequest, TaskModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<TaskModel> Insert(HttpRequest httpRequest, TaskModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<TaskModel> Search(HttpRequest httpRequest, TaskModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<TaskModel> Update(HttpRequest httpRequest, TaskModel model)
        {
            throw new NotImplementedException();
        }
    }
}
