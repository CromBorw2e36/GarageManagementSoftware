using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GarageManagementSoftware.Migrations
{
    /// <inheritdoc />
    public partial class update_enitty1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Access",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prive_buy = table.Column<double>(type: "float", nullable: true),
                    tax_percent = table.Column<double>(type: "float", nullable: true),
                    price_sell = table.Column<double>(type: "float", nullable: true),
                    inventory_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inventory_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "ActionForUser",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(newid())"),
                    table = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_add = table.Column<bool>(type: "bit", nullable: true),
                    is_view = table.Column<bool>(type: "bit", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionForUser", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeStatus",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeStatus", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "HistoryReciveOto",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    employee_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryReciveOto", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "PaymentVoucher",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    tax_percent = table.Column<double>(type: "float", nullable: true),
                    tax_price = table.Column<double>(type: "float", nullable: true),
                    price_total = table.Column<double>(type: "float", nullable: true),
                    discount = table.Column<double>(type: "float", nullable: true),
                    payment_total = table.Column<double>(type: "float", nullable: true),
                    payment_received = table.Column<double>(type: "float", nullable: true),
                    payment_change = table.Column<double>(type: "float", nullable: true),
                    is_payment = table.Column<bool>(type: "bit", nullable: true),
                    is_quote = table.Column<bool>(type: "bit", nullable: true),
                    print_count = table.Column<double>(type: "float", nullable: true),
                    historyReviceOto_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentVoucher", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "PaymentVoucherDetail",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    tax_percent = table.Column<double>(type: "float", nullable: true),
                    tax_price = table.Column<double>(type: "float", nullable: true),
                    price_total = table.Column<double>(type: "float", nullable: true),
                    discount = table.Column<double>(type: "float", nullable: true),
                    access_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentVoucher_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentVoucherDetail", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "RecieptVoucher",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    tax_percent = table.Column<double>(type: "float", nullable: true),
                    tax_price = table.Column<double>(type: "float", nullable: true),
                    price_total = table.Column<double>(type: "float", nullable: true),
                    discount = table.Column<double>(type: "float", nullable: true),
                    payment_total = table.Column<double>(type: "float", nullable: true),
                    payment_received = table.Column<double>(type: "float", nullable: true),
                    payment_change = table.Column<double>(type: "float", nullable: true),
                    is_payment = table.Column<bool>(type: "bit", nullable: true),
                    is_quote = table.Column<bool>(type: "bit", nullable: true),
                    inventory_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inventory_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    historyReviceOto_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecieptVoucher", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "RecieptVoucherDetail",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    tax_percent = table.Column<double>(type: "float", nullable: true),
                    tax_price = table.Column<double>(type: "float", nullable: true),
                    price_total = table.Column<double>(type: "float", nullable: true),
                    discount = table.Column<double>(type: "float", nullable: true),
                    recieptVoucher_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    access_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecieptVoucherDetail", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    project_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    project_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "TypeEmployee",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEmployee", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowStatus",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowStatus", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowType",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    create_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowType", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_customer = table.Column<bool>(type: "bit", nullable: true),
                    is_employee = table.Column<bool>(type: "bit", nullable: true),
                    is_supply = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.code);
                    table.ForeignKey(
                        name: "FK_Employee_User_code",
                        column: x => x.code,
                        principalTable: "User",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Access");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "ActionForUser");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeStatus");

            migrationBuilder.DropTable(
                name: "HistoryReciveOto");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "PaymentVoucher");

            migrationBuilder.DropTable(
                name: "PaymentVoucherDetail");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "RecieptVoucher");

            migrationBuilder.DropTable(
                name: "RecieptVoucherDetail");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "TypeEmployee");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "WorkFlowStatus");

            migrationBuilder.DropTable(
                name: "WorkFlowType");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
