using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using GarageManagementSoftware.Models.Interface.Function.Employee;

namespace GarageManagementSoftware.Models.Service.Function.Employee
{
    public class DepartmentService : DataSystemCommon, IDepartment
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<DepartmentModel> Delete(HttpRequest httpRequest, DepartmentModel model)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentModel> Get(HttpRequest httpRequest, DepartmentModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<DepartmentModel> Insert(HttpRequest httpRequest, DepartmentModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<DepartmentModel> Search(HttpRequest httpRequest, DepartmentModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<DepartmentModel> Update(HttpRequest httpRequest, DepartmentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
