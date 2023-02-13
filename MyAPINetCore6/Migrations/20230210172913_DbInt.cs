using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAPINetCore6.Migrations
{
    public partial class DbInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThongTinCCCN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mssv = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Khoa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lop = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenCN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChucVuNC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenNC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoQD = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgayCap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinCCCN", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongTinCCCN");
        }
    }
}
