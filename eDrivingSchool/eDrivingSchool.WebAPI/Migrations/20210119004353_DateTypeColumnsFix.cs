using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class DateTypeColumnsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfHiring",
                table: "Users",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Topics",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "TheoryTestApplications",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfPayment",
                table: "Payments",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "DrivingTestApplications",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Comments",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Certificate_Requests",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfHiring",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Topics",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "TheoryTestApplications",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfPayment",
                table: "Payments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "DrivingTestApplications",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Certificate_Requests",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
