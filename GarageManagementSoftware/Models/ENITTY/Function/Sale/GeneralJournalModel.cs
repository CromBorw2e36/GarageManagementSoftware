using GarageManagementSoftware.Models.ENITTY.DataSystem;

namespace GarageManagementSoftware.Models.ENITTY.Function.Sale
{
    public class GeneralJournalModel  // Sổ nhật ký chung 
    {
        public int? id { get; set; }
        public string? code { get; set; }
        public string? code_voucher { get; set; }
        public string? name { get; set; }
        public DateTime? record_date { get; set; } // Ngày chứng từ
        public string? desciption { get; set; }
        public string? document_number { get; set; }
        public string? accounting_number { get; set; } // Tài khoản kế toán
        public decimal? price { get; set; }
        public string? note { get; set; }
        public bool? is_delete { get; set; }
        public bool? is_active { get; set; }
        public CompanyModel? company { get; set; }
        public DateTime? create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
        public string? create_by { get; set; }
        public string? update_by { get; set; }
        public string? delete_by { get; set; }
    }
}
