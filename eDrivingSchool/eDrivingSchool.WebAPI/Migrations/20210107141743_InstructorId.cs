using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class InstructorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "DrivingLessons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLessons_InstructorId",
                table: "DrivingLessons",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrivingLessons_Users_InstructorId",
                table: "DrivingLessons",
                column: "InstructorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrivingLessons_Users_InstructorId",
                table: "DrivingLessons");

            migrationBuilder.DropIndex(
                name: "IX_DrivingLessons_InstructorId",
                table: "DrivingLessons");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "DrivingLessons");
        }
    }
}
