using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;

namespace GarageManagementSoftware.Models.Interface.Function.WorkFlow
{
    public interface IProject
    {
        public string tableName { get; set; }
        public List<ProjectModel> Get(HttpRequest httpRequest, ProjectModel model);
        public StatusMessege<ProjectModel> Insert(HttpRequest httpRequest, ProjectModel model);
        public StatusMessege<ProjectModel> Update(HttpRequest httpRequest, ProjectModel model);
        public StatusMessege<ProjectModel> Delete(HttpRequest httpRequest, ProjectModel model);
        public StatusMessege<ProjectModel> Search(HttpRequest httpRequest, ProjectModel model);
    }
}
