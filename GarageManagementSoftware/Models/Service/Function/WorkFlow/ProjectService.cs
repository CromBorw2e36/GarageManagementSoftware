using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;
using GarageManagementSoftware.Models.Interface.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Service.Function.WorkFlow
{
    public class ProjectService : DataSystemCommon, IProject
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<ProjectModel> Delete(HttpRequest httpRequest, ProjectModel model)
        {
            throw new NotImplementedException();
        }

        public List<ProjectModel> Get(HttpRequest httpRequest, ProjectModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<ProjectModel> Insert(HttpRequest httpRequest, ProjectModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<ProjectModel> Search(HttpRequest httpRequest, ProjectModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<ProjectModel> Update(HttpRequest httpRequest, ProjectModel model)
        {
            throw new NotImplementedException();
        }
    }
}
