using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Interface.Function.WorkFlow
{
    public interface IWorkFlowType
    {
        public string tableName { get; set; }
        public List<WorkFlowTypeModel> Get(HttpRequest httpRequest, WorkFlowTypeModel model);
        public StatusMessege<WorkFlowTypeModel> Insert(HttpRequest httpRequest, WorkFlowTypeModel model);
        public StatusMessege<WorkFlowTypeModel> Update(HttpRequest httpRequest, WorkFlowTypeModel model);
        public StatusMessege<WorkFlowTypeModel> Delete(HttpRequest httpRequest, WorkFlowTypeModel model);
        public StatusMessege<WorkFlowTypeModel> Search(HttpRequest httpRequest, WorkFlowTypeModel model);
    }
}
