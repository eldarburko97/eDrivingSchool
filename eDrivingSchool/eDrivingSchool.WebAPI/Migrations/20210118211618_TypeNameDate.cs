using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class TypeNameDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Instructors_Categories_Candidates",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Instructors_Categories_Candidates",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);
        }
    }
}
