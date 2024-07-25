using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;
using GarageManagementSoftware.Models.Interface.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Service.Function.WorkFlow
{
    public class WorkFlowStatusService : DataSystemCommon, IWorkFlowStatus
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<WorkFlowStatusModel> Delete(HttpRequest httpRequest, WorkFlowStatusModel model)
        {
            throw new NotImplementedException();
        }

        public List<WorkFlowStatusModel> Get(HttpRequest httpRequest, WorkFlowStatusModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<WorkFlowStatusModel> Insert(HttpRequest httpRequest, WorkFlowStatusModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<WorkFlowStatusModel> Search(HttpRequest httpRequest, WorkFlowStatusModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<WorkFlowStatusModel> Update(HttpRequest httpRequest, WorkFlowStatusModel model)
        {
            throw new NotImplementedException();
        }
    }
}
