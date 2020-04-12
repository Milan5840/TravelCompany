using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberDays",
                table: "ExpensesType");

            migrationBuilder.RenameColumn(
                name: "VisitReason",
                table: "ExpensesType",
                newName: "PhotoReceiptPath");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ExpensesType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "ExpensesType");

            migrationBuilder.RenameColumn(
                name: "PhotoReceiptPath",
                table: "ExpensesType",
                newName: "VisitReason");

            migrationBuilder.AddColumn<int>(
                name: "NumberDays",
                table: "ExpensesType",
                nullable: false,
                defaultValue: 0);
        }
    }
}
