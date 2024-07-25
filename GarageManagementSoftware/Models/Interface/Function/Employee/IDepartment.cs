using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;

namespace GarageManagementSoftware.Models.Interface.Function.Employee
{
    public interface IDepartment
    {
        public string tableName { get; set; }
        public List<DepartmentModel> Get(HttpRequest httpRequest, DepartmentModel model);
        public StatusMessege<DepartmentModel> Insert(HttpRequest httpRequest, DepartmentModel model);
        public StatusMessege<DepartmentModel> Update(HttpRequest httpRequest, DepartmentModel model);
        public StatusMessege<DepartmentModel> Delete(HttpRequest httpRequest, DepartmentModel model);
        public StatusMessege<DepartmentModel> Search(HttpRequest httpRequest, DepartmentModel model);
    }
}
