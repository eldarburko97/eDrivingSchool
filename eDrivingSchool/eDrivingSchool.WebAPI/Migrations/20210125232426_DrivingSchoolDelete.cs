using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class DrivingSchoolDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_DrivingSchool_DrivingSchoolId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "DrivingSchool");

            migrationBuilder.DropIndex(
                name: "IX_Users_DrivingSchoolId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DrivingSchoolId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrivingSchoolId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DrivingSchool",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingSchool", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DrivingSchoolId",
                table: "Users",
                column: "DrivingSchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_DrivingSchool_DrivingSchoolId",
                table: "Users",
                column: "DrivingSchoolId",
                principalTable: "DrivingSchool",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
