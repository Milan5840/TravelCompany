using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class ChangesLast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesType_Expenses_ExpensesEntityid",
                table: "ExpensesType");

            migrationBuilder.DropForeignKey(
                name: "FK_Travel_ExpensesType_ExpensesTypeEntityid",
                table: "Travel");

            migrationBuilder.DropIndex(
                name: "IX_Travel_ExpensesTypeEntityid",
                table: "Travel");

            migrationBuilder.DropColumn(
                name: "ExpensesTypeEntityid",
                table: "Travel");

            migrationBuilder.RenameColumn(
                name: "ExpensesEntityid",
                table: "ExpensesType",
                newName: "TravelEntityid");

            migrationBuilder.RenameIndex(
                name: "IX_ExpensesType_ExpensesEntityid",
                table: "ExpensesType",
                newName: "IX_ExpensesType_TravelEntityid");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ExpensesType",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpensesTypeEntityid",
                table: "Expenses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Travelid",
                table: "Expenses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpensesTypeEntityid",
                table: "Expenses",
                column: "ExpensesTypeEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_Travelid",
                table: "Expenses",
                column: "Travelid");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpensesType_ExpensesTypeEntityid",
                table: "Expenses",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Travel_Travelid",
                table: "Expenses",
                column: "Travelid",
                principalTable: "Travel",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpensesType_ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Travel_Travelid",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesType_Travel_TravelEntityid",
                table: "ExpensesType");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_Travelid",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpensesTypeEntityid",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Travelid",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "TravelEntityid",
                table: "ExpensesType",
                newName: "ExpensesEntityid");

            migrationBuilder.RenameIndex(
                name: "IX_ExpensesType_TravelEntityid",
                table: "ExpensesType",
                newName: "IX_ExpensesType_ExpensesEntityid");

            migrationBuilder.AddColumn<int>(
                name: "ExpensesTypeEntityid",
                table: "Travel",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ExpensesType",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Travel_ExpensesTypeEntityid",
                table: "Travel",
                column: "ExpensesTypeEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesType_Expenses_ExpensesEntityid",
                table: "ExpensesType",
                column: "ExpensesEntityid",
                principalTable: "Expenses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Travel_ExpensesType_ExpensesTypeEntityid",
                table: "Travel",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
