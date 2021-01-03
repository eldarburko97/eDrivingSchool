using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class TheoryTestApplications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InstructorCategoryCandidateId",
                table: "Instructors_Categories_Candidates",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserCategoryId",
                table: "Instructors_Categories",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "Polozio",
                table: "Instructors_Categories_Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Prijavljen",
                table: "Instructors_Categories_Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "TheoryTestApplications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Instructor_Category_CandidateId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    FirstAid = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheoryTestApplications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TheoryTestApplications");

            migrationBuilder.DropColumn(
                name: "Polozio",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropColumn(
                name: "Prijavljen",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instructors_Categories_Candidates",
                newName: "InstructorCategoryCandidateId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instructors_Categories",
                newName: "UserCategoryId");
        }
    }
}
