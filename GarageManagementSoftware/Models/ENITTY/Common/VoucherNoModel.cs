using GarageManagementSoftware.Models.ENITTY.DataSystem;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManagementSoftware.Models.ENITTY.Common
{
    public class VoucherNoModel
    {
        public string? id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? length { get; set; }
        public string? first { get; set; }
        public string? create_at { get; set; }
        public string? create_by { get; set; }
        public string? create_fullName { get; set; }
        [NotMapped]
        public UserModel? user { get; set; }
    }
}
