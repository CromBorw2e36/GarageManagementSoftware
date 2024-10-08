﻿using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSoftware.Models.ENITTY.Function.Sale
{
    public class RecieptVoucherModel
    {
        public int? id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? document_number { get; set; } // Số chứng từ
        public string? description { get; set; }
        public bool? is_delete { get; set; }
        public bool? is_active { get; set; }
        public double? price { get; set; }    // Thành tiền
        public double? tax_percent { get; set; } // % thuế
        public double? tax_price { get; set; } // Thành tiền thuế
        public double? price_total { get; set; } // Tổng tiền chưa thuế
        public double? discount { get; set; } // Tiền giảm giá
        public double? payment_total { get; set; } // Tổng tiền thanh toán
        public double? payment_received { get; set; } // Số tiền nhận từ khách hàng
        public double? payment_change { get; set; } // Tiền thối lại khách hàng
        public bool? is_payment { get; set; } // Đã thanh toán
        public bool? is_quote { get; set; } // Đã báo giá
        public string? inventory_code { get; set; }
        public string? inventory_name { get; set; }
        public string? sign { get; set; } // Chữ ký
        public string? accounting_number { get; set; } // Tài khoản kế toán
        [NotMapped]
        public InventoryModel? inventory { get; set; }
        public string? historyReviceOto_code { get; set; }
        [NotMapped]
        public HistoryReciveOtoModel? historyReviceOto { get; set; }
        [NotMapped]
        public List<RecieptVoucherDetailModel>? detail { get; set; }
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
