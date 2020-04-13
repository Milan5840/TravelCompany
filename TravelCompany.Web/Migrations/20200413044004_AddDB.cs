using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class AddDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpensesType_ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesType_Travel_TravelEntityid",
                table: "ExpensesType");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "TravelEntityid",
                table: "ExpensesType",
                newName: "ExpensesTypeEntityid");

            migrationBuilder.RenameIndex(
                name: "IX_ExpensesType_TravelEntityid",
                table: "ExpensesType",
                newName: "IX_ExpensesType_ExpensesTypeEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesType_ExpensesType_ExpensesTypeEntityid",
                table: "ExpensesType",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesType_ExpensesType_ExpensesTypeEntityid",
                table: "ExpensesType");

            migrationBuilder.RenameColumn(
                name: "ExpensesTypeEntityid",
                table: "ExpensesType",
                newName: "TravelEntityid");

            migrationBuilder.RenameIndex(
                name: "IX_ExpensesType_ExpensesTypeEntityid",
                table: "ExpensesType",
                newName: "IX_ExpensesType_TravelEntityid");

            migrationBuilder.AddColumn<int>(
                name: "ExpensesTypeEntityid",
                table: "Expenses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpensesTypeEntityid",
                table: "Expenses",
                column: "ExpensesTypeEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpensesType_ExpensesTypeEntityid",
                table: "Expenses",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesType_Travel_TravelEntityid",
                table: "ExpensesType",
                column: "TravelEntityid",
                principalTable: "Travel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
