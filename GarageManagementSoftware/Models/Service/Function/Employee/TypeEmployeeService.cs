using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using GarageManagementSoftware.Models.Interface.Function.Employee;

namespace GarageManagementSoftware.Models.Service.Function.Employee
{
    public class TypeEmployeeService : DataSystemCommon, ITypeEmployee
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<TypeEmployeeModel> Delete(HttpRequest httpRequest, TypeEmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public List<TypeEmployeeModel> Get(HttpRequest httpRequest, TypeEmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<TypeEmployeeModel> Insert(HttpRequest httpRequest, TypeEmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<TypeEmployeeModel> Search(HttpRequest httpRequest, TypeEmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<TypeEmployeeModel> Update(HttpRequest httpRequest, TypeEmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
