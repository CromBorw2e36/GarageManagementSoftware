using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSoftware.Models.ENITTY.Function.Sale
{
    public class RecieptVoucherDetailModel
    {
        public int? id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public bool? is_delete { get; set; }
        public bool? is_active { get; set; }
        public double? price { get; set; }
        public double? tax_percent { get; set; }
        public double? tax_price { get; set; }
        public double? price_total { get; set; }
        public double? discount { get; set; }
        public string? recieptVoucher_code { get; set; }
        public string? access_code { get; set; }
        [NotMapped]
        public AccessModel access { get; set; }
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
