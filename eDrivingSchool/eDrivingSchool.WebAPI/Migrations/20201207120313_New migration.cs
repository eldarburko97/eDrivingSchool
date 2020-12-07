using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class Newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Certificate_Requests",
                newName: "CertificateRequestId");

            migrationBuilder.CreateTable(
                name: "Users_Categories",
                columns: table => new
                {
                    UserCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
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
                name: "IX_Certificate_Requests_CertificateId",
                table: "Certificate_Requests",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_Requests_UserId",
                table: "Certificate_Requests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Categories_CategoryId",
                table: "Users_Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Categories_UserId",
                table: "Users_Categories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_Requests_Certificates_CertificateId",
                table: "Certificate_Requests",
                column: "CertificateId",
                principalTable: "Certificates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_Requests_Users_UserId",
                table: "Certificate_Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_Requests_Certificates_CertificateId",
                table: "Certificate_Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_Requests_Users_UserId",
                table: "Certificate_Requests");

            migrationBuilder.DropTable(
                name: "Users_Categories");

            migrationBuilder.DropIndex(
                name: "IX_Certificate_Requests_CertificateId",
                table: "Certificate_Requests");

            migrationBuilder.DropIndex(
                name: "IX_Certificate_Requests_UserId",
                table: "Certificate_Requests");

            migrationBuilder.RenameColumn(
                name: "CertificateRequestId",
                table: "Certificate_Requests",
                newName: "Id");
        }
    }
}
