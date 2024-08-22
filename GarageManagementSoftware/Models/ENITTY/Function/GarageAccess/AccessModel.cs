using GarageManagementSoftware.Models.ENITTY.DataSystem;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSoftware.Models.ENITTY.Function.GarageAccess
{
    public class AccessModel
    {
        public string? id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public double? prive_buy { get; set; }
        public double? tax_percent { get; set; }
        public double? price_sell { get; set; }
        public string? inventory_code { get; set; }
        public string? inventory_name {  get; set; }
        [NotMapped]
        public InventoryModel? inventory { get; set; }
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
