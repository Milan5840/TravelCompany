using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpensesType_ExpensesTypeid",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpensesTypeid",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Hour",
                table: "TravelDetails");

            migrationBuilder.DropColumn(
                name: "ExpensesTypeid",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "ExpensesTypeEntityid",
                table: "TravelDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpensesEntityid",
                table: "ExpensesType",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelDetails_ExpensesTypeEntityid",
                table: "TravelDetails",
                column: "ExpensesTypeEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesType_ExpensesEntityid",
                table: "ExpensesType",
                column: "ExpensesEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesType_Expenses_ExpensesEntityid",
                table: "ExpensesType",
                column: "ExpensesEntityid",
                principalTable: "Expenses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelDetails_ExpensesType_ExpensesTypeEntityid",
                table: "TravelDetails",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesType_Expenses_ExpensesEntityid",
                table: "ExpensesType");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelDetails_ExpensesType_ExpensesTypeEntityid",
                table: "TravelDetails");

            migrationBuilder.DropIndex(
                name: "IX_TravelDetails_ExpensesTypeEntityid",
                table: "TravelDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExpensesType_ExpensesEntityid",
                table: "ExpensesType");

            migrationBuilder.DropColumn(
                name: "ExpensesTypeEntityid",
                table: "TravelDetails");

            migrationBuilder.DropColumn(
                name: "ExpensesEntityid",
                table: "ExpensesType");

            migrationBuilder.AddColumn<DateTime>(
                name: "Hour",
                table: "TravelDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ExpensesTypeid",
                table: "Expenses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpensesTypeid",
                table: "Expenses",
                column: "ExpensesTypeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpensesType_ExpensesTypeid",
                table: "Expenses",
                column: "ExpensesTypeid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
