using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class DrivingLessonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DrivingLessons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false),
                    Mileage = table.Column<float>(nullable: false),
                    AverageFuelConsumption = table.Column<float>(nullable: false),
                    Damage = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrivingLessons_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrivingLessons_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLessons_UserId",
                table: "DrivingLessons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLessons_VehicleId",
                table: "DrivingLessons",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrivingLessons");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Vehicles");
        }
    }
}
