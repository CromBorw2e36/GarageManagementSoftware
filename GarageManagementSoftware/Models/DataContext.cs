using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Employee;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.ENITTY.Function.WorkFlow;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GarageManagementSoftware.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string DbContextString2 = "Data Source=KHANHNGUYENLAPT;Initial Catalog=GarageManagementSoftware;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=True;Trust Server Certificate=True;Command Timeout=0";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbContextString2);
            }
        }

        public DbSet<AccountModel> AccountModel { get; set; }
        public DbSet<UnitModel> UnitModel { get; set; }
        public DbSet<CompanyModel> CompanyModel { get; set; }
        public DbSet<PermissionModel> PermissionModel { get; set; }
        public DbSet<UserModel> UserModel { get; set; }
        public DbSet<DepartmentModel> DepartmentModel { get; set; }
        public DbSet<EmployeeModel> EmployeeModel { get; set; }
        public DbSet<TypeEmployeeModel> TypeEmployeeModel { get; set; }
        public DbSet<AccessModel> AccessModel { get; set; }
        public DbSet<InventoryModel> InventoryModel { get; set; }
        public DbSet<HistoryReciveOtoModel> HistoryReciveOtoModel { get; set; }
        public DbSet<PaymentVoucherDetailModel> PaymentVoucherDetailModel { get; set; }
        public DbSet<PaymentVoucherModel> PaymentVoucherModel { get; set; }
        public DbSet<RecieptVoucherDetailModel> RecieptVoucherDetailModel { get; set; }
        public DbSet<RecieptVoucherModel> RecieptVoucherModel { get; set; }
        public DbSet<ProjectModel> ProjectModel { get; set; }
        public DbSet<TaskModel> TaskModel { get; set; }
        public DbSet<WorkFlowStatusModel> WorkFlowStatusModel { get; set; }
        public DbSet<WorkFlowTypeModel> WorkFlowTypeModel { get; set; }
        public DbSet<EmployeeStatusModel> EmployeeStatusModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountModel>(e => { e.ToTable("Account"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<UnitModel>(e => { e.ToTable("Unit"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<CompanyModel>(e => { e.ToTable("Company"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<PermissionModel>(e => { e.ToTable("Permission"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<UserModel>(e => { e.ToTable("User"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<DepartmentModel>(e => { e.ToTable("Department"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<EmployeeModel>(e => { e.ToTable("Employee"); });
            modelBuilder.Entity<TypeEmployeeModel>(e => { e.ToTable("TypeEmployee"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<AccessModel>(e => { e.ToTable("Access"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<InventoryModel>(e => { e.ToTable("Inventory"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); }); 
            modelBuilder.Entity<HistoryReciveOtoModel>(e => { e.ToTable("HistoryReciveOto"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<PaymentVoucherDetailModel>(e => { e.ToTable("PaymentVoucherDetail"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<PaymentVoucherModel>(e => { e.ToTable("PaymentVoucher"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<RecieptVoucherDetailModel>(e => { e.ToTable("RecieptVoucherDetail"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<RecieptVoucherModel>(e => { e.ToTable("RecieptVoucher"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<ProjectModel>(e => { e.ToTable("Project"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<TaskModel>(e => { e.ToTable("Task"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<WorkFlowStatusModel>(e => { e.ToTable("WorkFlowStatus"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<WorkFlowTypeModel>(e => { e.ToTable("WorkFlowType"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd();  e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
            modelBuilder.Entity<EmployeeStatusModel> (e => { e.ToTable("EmployeeStatus"); e.HasKey(e => e.code); e.Property(e => e.id).ValueGeneratedOnAdd(); e.Property(e => e.is_active).HasDefaultValue(true); e.Property(e => e.is_delete).HasDefaultValue(false); });
        }
    }

}
