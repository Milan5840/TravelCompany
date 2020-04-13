using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class ExpensesTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpenseTotal",
                table: "Travel");

            migrationBuilder.AddColumn<double>(
                name: "ExpenseTotal",
                table: "Expenses",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpenseTotal",
                table: "Expenses");

            migrationBuilder.AddColumn<double>(
                name: "ExpenseTotal",
                table: "Travel",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
