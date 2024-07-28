namespace GarageManagementSoftware.Models.ENITTY.DataSystem
{
    public class AccountModel
    {
        public int? id {  get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? password { get; set; }   
        public string? password2 { get; set; }
        public string? email { get; set; }
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
