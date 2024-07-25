using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using GarageManagementSoftware.Models.Interface.Function.Employee;

namespace GarageManagementSoftware.Models.Service.Function.Employee
{
    public class EmployeeService : DataSystemCommon, IEmployee
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<EmployeeModel> Delete(HttpRequest httpRequest, EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> Get(HttpRequest httpRequest, EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<EmployeeModel> Insert(HttpRequest httpRequest, EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<EmployeeModel> Search(HttpRequest httpRequest, EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<EmployeeModel> Update(HttpRequest httpRequest, EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
