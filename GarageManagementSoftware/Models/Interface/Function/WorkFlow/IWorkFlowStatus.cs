using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Interface.Function.WorkFlow
{
    public interface IWorkFlowStatus
    {
        public string tableName { get; set; }
        public List<WorkFlowStatusModel> Get(HttpRequest httpRequest, WorkFlowStatusModel model);
        public StatusMessege<WorkFlowStatusModel> Insert(HttpRequest httpRequest, WorkFlowStatusModel model);
        public StatusMessege<WorkFlowStatusModel> Update(HttpRequest httpRequest, WorkFlowStatusModel model);
        public StatusMessege<WorkFlowStatusModel> Delete(HttpRequest httpRequest, WorkFlowStatusModel model);
        public StatusMessege<WorkFlowStatusModel> Search(HttpRequest httpRequest, WorkFlowStatusModel model); 
    }
}
