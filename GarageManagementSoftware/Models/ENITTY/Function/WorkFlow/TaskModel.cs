using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSoftware.Models.ENITTY.Function.WorkFlow
{
    public class TaskModel
    {
        public int? id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? status_code { get; set; }
        public string? status_name { get; set; }
        public string? project_code { get; set;}
        public string? project_name { get; set; }
        public string? type_code { get; set; }
        public string? type_name { get; set; }
        public string? employee_code { get; set; }
        [NotMapped]
        public EmployeeModel? employee { get; set; }
        [NotMapped]
        public WorkFlowStatusModel? status { get; set; }
        [NotMapped]
        public WorkFlowTypeModel? type { get; set; }
        [NotMapped]
        public ProjectModel? project { get; set; }
        public string? company_code { get; set; }
        public string? company_name { get; set; }
        [NotMapped]
        public CompanyModel? company { get; set; }
        public bool? is_delete { get; set; }
        public bool? is_active { get; set; }
        public DateTime? create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
        public string? create_by { get; set; }
        public string? update_by { get; set; }
        public string? delete_by { get; set; }
    }
}
