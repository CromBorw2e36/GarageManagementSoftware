using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;

namespace GarageManagementSoftware.Models.Interface.Function.Employee
{
    public interface IEmployeeStatus
    {
        public string tableName { get => this.tableName; set => this.tableName = "EmployeeStatus"; }
        public List<EmployeeStatusModel> Get(HttpRequest httpRequest, EmployeeStatusModel model);
        public StatusMessege<EmployeeStatusModel> Insert(HttpRequest httpRequest, EmployeeStatusModel model);
        public StatusMessege<EmployeeStatusModel> Update(HttpRequest httpRequest, EmployeeStatusModel model);
        public StatusMessege<EmployeeStatusModel> Delete(HttpRequest httpRequest, EmployeeStatusModel model);
        public StatusMessege<EmployeeStatusModel> Search(HttpRequest httpRequest, EmployeeStatusModel model);
    }
}
