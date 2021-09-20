using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace demo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentName = table.Column<string>(type: "TEXT", nullable: true),
                    NamSinh = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.IdStudent);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
