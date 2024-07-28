using GarageManagementSoftware.Models.ENITTY.DataSystem;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSoftware.Models.ENITTY.Function.GarageAccess
{
    public class InventoryModel
    {
        public int? id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public bool? is_delete { get; set; }
        public bool? is_active { get; set; }
        public string? company_code { get; set; }
        public string? company_name { get; set; }
        [NotMapped]
        public CompanyModel? company { get; set; }
        public DateTime? create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
        public string? create_by { get; set; }
        public string? update_by { get; set; }
        public string? delete_by { get; set; }
    }
}
