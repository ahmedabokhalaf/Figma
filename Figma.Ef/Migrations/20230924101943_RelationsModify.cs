using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Figma.Ef.Migrations
{
    public partial class RelationsModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_ProfileId",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<int>(
                name: "PersonalInfoId",
                table: "ApplicationForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_ProfileId",
                table: "ApplicationForms",
                column: "ProfileId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_ProfileId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "PersonalInfoId",
                table: "ApplicationForms");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_ProfileId",
                table: "ApplicationForms",
                column: "ProfileId");
        }
    }
}
