using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;

namespace GarageManagementSoftware.Models.Interface.Function.Employee
{
    public interface ITypeEmployee
    {
        public string tableName { get => this.tableName; set => this.tableName = "TypeEmployee"; }
        public List<TypeEmployeeModel> Get(HttpRequest httpRequest, TypeEmployeeModel model);
        public StatusMessege<TypeEmployeeModel> Insert(HttpRequest httpRequest, TypeEmployeeModel model);
        public StatusMessege<TypeEmployeeModel> Update(HttpRequest httpRequest, TypeEmployeeModel model);
        public StatusMessege<TypeEmployeeModel> Delete(HttpRequest httpRequest, TypeEmployeeModel model);
        public StatusMessege<TypeEmployeeModel> Search(HttpRequest httpRequest, TypeEmployeeModel model);
    }
}
