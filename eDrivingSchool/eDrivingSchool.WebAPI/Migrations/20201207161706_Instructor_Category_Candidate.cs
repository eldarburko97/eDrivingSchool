using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class Instructor_Category_Candidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users_Categories");

            migrationBuilder.CreateTable(
                name: "Instructors_Categories",
                columns: table => new
                {
                    UserCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors_Categories", x => x.UserCategoryId);
                    table.ForeignKey(
                        name: "FK_Instructors_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructors_Categories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructors_Categories_Candidates",
                columns: table => new
                {
                    InstructorCategoryCandidateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Instructor_CategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors_Categories_Candidates", x => x.InstructorCategoryCandidateId);
                    table.ForeignKey(
                        name: "FK_Instructors_Categories_Candidates_Instructors_Categories_Instructor_CategoryId",
                        column: x => x.Instructor_CategoryId,
                        principalTable: "Instructors_Categories",
                        principalColumn: "UserCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructors_Categories_Candidates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Categories_CategoryId",
                table: "Instructors_Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Categories_UserId",
                table: "Instructors_Categories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Categories_Candidates_Instructor_CategoryId",
                table: "Instructors_Categories_Candidates",
                column: "Instructor_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Categories_Candidates_UserId",
                table: "Instructors_Categories_Candidates",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors_Categories_Candidates");

            migrationBuilder.DropTable(
                name: "Instructors_Categories");

            migrationBuilder.CreateTable(
                name: "Users_Categories",
                columns: table => new
                {
                    UserCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Categories", x => x.UserCategoryId);
                    table.ForeignKey(
                        name: "FK_Users_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Categories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Categories_CategoryId",
                table: "Users_Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Categories_UserId",
                table: "Users_Categories",
                column: "UserId");
        }
    }
}
