﻿using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;

namespace GarageManagementSoftware.Models.Interface.Function.Employee
{
    public interface IEmployeeStatus
    {
        public string tableName { get; set; }
        public List<EmployeeModel> Get(HttpRequest httpRequest, EmployeeModel model);
        public StatusMessege<EmployeeModel> Insert(HttpRequest httpRequest, EmployeeModel model);
        public StatusMessege<EmployeeModel> Update(HttpRequest httpRequest, EmployeeModel model);
        public StatusMessege<EmployeeModel> Delete(HttpRequest httpRequest, EmployeeModel model);
        public StatusMessege<EmployeeModel> Search(HttpRequest httpRequest, EmployeeModel model);
    }
}
