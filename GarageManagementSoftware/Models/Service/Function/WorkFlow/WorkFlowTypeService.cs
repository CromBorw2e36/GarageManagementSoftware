using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;
using GarageManagementSoftware.Models.Interface.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Service.Function.WorkFlow
{
    public class WorkFlowTypeService : DataSystemCommon, IWorkFlowType
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }

        public StatusMessege<WorkFlowTypeModel> Delete(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            throw new NotImplementedException();
        }

        public List<WorkFlowTypeModel> Get(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<WorkFlowTypeModel> Insert(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<WorkFlowTypeModel> Search(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<WorkFlowTypeModel> Update(HttpRequest httpRequest, WorkFlowTypeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
