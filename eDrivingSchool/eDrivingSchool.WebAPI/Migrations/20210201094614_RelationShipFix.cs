using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class RelationShipFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrivingTestApplications_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "DrivingTestApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Categories_Users_UserId",
                table: "Instructors_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Categories_Candidates_Instructors_Categories_Instructor_CategoryId",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Categories_Candidates_Users_UserId",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TheoryTestApplications_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "TheoryTestApplications");

            migrationBuilder.DropIndex(
                name: "IX_TheoryTestApplications_Instructor_Category_CandidateId",
                table: "TheoryTestApplications");

            migrationBuilder.DropIndex(
                name: "IX_Payments_Instructor_Category_CandidateId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors_Categories_Candidates",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Categories_Candidates_Instructor_CategoryId",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors_Categories",
                table: "Instructors_Categories");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Categories_UserId",
                table: "Instructors_Categories");

            migrationBuilder.DropIndex(
                name: "IX_DrivingTestApplications_Instructor_Category_CandidateId",
                table: "DrivingTestApplications");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Instructors_Categories");

            migrationBuilder.RenameColumn(
                name: "Instructor_Category_CandidateId",
                table: "TheoryTestApplications",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "Instructor_Category_CandidateId",
                table: "Payments",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Instructors_Categories_Candidates",
                newName: "CandidateId");

            migrationBuilder.RenameColumn(
                name: "Instructor_CategoryId",
                table: "Instructors_Categories_Candidates",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Categories_Candidates_UserId",
                table: "Instructors_Categories_Candidates",
                newName: "IX_Instructors_Categories_Candidates_CandidateId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Instructors_Categories",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "Instructor_Category_CandidateId",
                table: "DrivingTestApplications",
                newName: "InstructorId");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "TheoryTestApplications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "TheoryTestApplications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Instructors_Categories_Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "DrivingTestApplications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "DrivingTestApplications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors_Categories_Candidates",
                table: "Instructors_Categories_Candidates",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors_Categories",
                table: "Instructors_Categories",
                columns: new[] { "InstructorId", "CategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_TheoryTestApplications_InstructorId_CategoryId_CandidateId",
                table: "TheoryTestApplications",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_InstructorId_CategoryId_CandidateId",
                table: "Payments",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" });

            migrationBuilder.CreateIndex(
                name: "IX_DrivingTestApplications_InstructorId_CategoryId_CandidateId",
                table: "DrivingTestApplications",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DrivingTestApplications_Instructors_Categories_Candidates_InstructorId_CategoryId_CandidateId",
                table: "DrivingTestApplications",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" },
                principalTable: "Instructors_Categories_Candidates",
                principalColumns: new[] { "InstructorId", "CategoryId", "CandidateId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Categories_Users_InstructorId",
                table: "Instructors_Categories",
                column: "InstructorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Categories_Candidates_Users_CandidateId",
                table: "Instructors_Categories_Candidates",
                column: "CandidateId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Categories_Candidates_Instructors_Categories_InstructorId_CategoryId",
                table: "Instructors_Categories_Candidates",
                columns: new[] { "InstructorId", "CategoryId" },
                principalTable: "Instructors_Categories",
                principalColumns: new[] { "InstructorId", "CategoryId" },
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Instructors_Categories_Candidates_InstructorId_CategoryId_CandidateId",
                table: "Payments",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" },
                principalTable: "Instructors_Categories_Candidates",
                principalColumns: new[] { "InstructorId", "CategoryId", "CandidateId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TheoryTestApplications_Instructors_Categories_Candidates_InstructorId_CategoryId_CandidateId",
                table: "TheoryTestApplications",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" },
                principalTable: "Instructors_Categories_Candidates",
                principalColumns: new[] { "InstructorId", "CategoryId", "CandidateId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrivingTestApplications_Instructors_Categories_Candidates_InstructorId_CategoryId_CandidateId",
                table: "DrivingTestApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Categories_Users_InstructorId",
                table: "Instructors_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Categories_Candidates_Users_CandidateId",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Categories_Candidates_Instructors_Categories_InstructorId_CategoryId",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Instructors_Categories_Candidates_InstructorId_CategoryId_CandidateId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TheoryTestApplications_Instructors_Categories_Candidates_InstructorId_CategoryId_CandidateId",
                table: "TheoryTestApplications");

            migrationBuilder.DropIndex(
                name: "IX_TheoryTestApplications_InstructorId_CategoryId_CandidateId",
                table: "TheoryTestApplications");

            migrationBuilder.DropIndex(
                name: "IX_Payments_InstructorId_CategoryId_CandidateId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors_Categories_Candidates",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors_Categories",
                table: "Instructors_Categories");

            migrationBuilder.DropIndex(
                name: "IX_DrivingTestApplications_InstructorId_CategoryId_CandidateId",
                table: "DrivingTestApplications");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "TheoryTestApplications");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "TheoryTestApplications");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "DrivingTestApplications");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "DrivingTestApplications");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "TheoryTestApplications",
                newName: "Instructor_Category_CandidateId");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Payments",
                newName: "Instructor_Category_CandidateId");

            migrationBuilder.RenameColumn(
                name: "CandidateId",
                table: "Instructors_Categories_Candidates",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Instructors_Categories_Candidates",
                newName: "Instructor_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Categories_Candidates_CandidateId",
                table: "Instructors_Categories_Candidates",
                newName: "IX_Instructors_Categories_Candidates_UserId");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Instructors_Categories",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "DrivingTestApplications",
                newName: "Instructor_Category_CandidateId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Instructors_Categories_Candidates",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Instructors_Categories",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors_Categories_Candidates",
                table: "Instructors_Categories_Candidates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors_Categories",
                table: "Instructors_Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TheoryTestApplications_Instructor_Category_CandidateId",
                table: "TheoryTestApplications",
                column: "Instructor_Category_CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Instructor_Category_CandidateId",
                table: "Payments",
                column: "Instructor_Category_CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Categories_Candidates_Instructor_CategoryId",
                table: "Instructors_Categories_Candidates",
                column: "Instructor_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Categories_UserId",
                table: "Instructors_Categories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DrivingTestApplications_Instructor_Category_CandidateId",
                table: "DrivingTestApplications",
                column: "Instructor_Category_CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrivingTestApplications_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "DrivingTestApplications",
                column: "Instructor_Category_CandidateId",
                principalTable: "Instructors_Categories_Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Categories_Users_UserId",
                table: "Instructors_Categories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Categories_Candidates_Instructors_Categories_Instructor_CategoryId",
                table: "Instructors_Categories_Candidates",
                column: "Instructor_CategoryId",
                principalTable: "Instructors_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Categories_Candidates_Users_UserId",
                table: "Instructors_Categories_Candidates",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "Payments",
                column: "Instructor_Category_CandidateId",
                principalTable: "Instructors_Categories_Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TheoryTestApplications_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "TheoryTestApplications",
                column: "Instructor_Category_CandidateId",
                principalTable: "Instructors_Categories_Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
