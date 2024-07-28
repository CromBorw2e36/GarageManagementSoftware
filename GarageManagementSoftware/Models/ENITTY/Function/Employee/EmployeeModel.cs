using GarageManagementSoftware.Models.ENITTY.DataSystem;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSoftware.Models.ENITTY.Function.Employee
{
    public class EmployeeModel: UserModel
    {
        public string? company_code { get; set; }
        public string? company_name { get; set; }
        [NotMapped]
        public CompanyModel? company { get; set; }
        public bool? is_customer { get; set; }
        public bool? is_employee { get; set; }
        public bool? is_supply { get; set; }
    }
}
