using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Figma.Ef.Migrations
{
    public partial class RelationsModifies2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalInfoId",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "Stages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Questions",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "FigmaPrograms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ApplicationsQuestions",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationsQuestions", x => new { x.ApplicationId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_ApplicationsQuestions_ApplicationForms_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationsQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stages_ProgramId",
                table: "Stages",
                column: "ProgramId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FigmaPrograms_ApplicationId",
                table: "FigmaPrograms",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationsQuestions_QuestionId",
                table: "ApplicationsQuestions",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FigmaPrograms_ApplicationForms_ApplicationId",
                table: "FigmaPrograms",
                column: "ApplicationId",
                principalTable: "ApplicationForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stages_FigmaPrograms_ProgramId",
                table: "Stages",
                column: "ProgramId",
                principalTable: "FigmaPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FigmaPrograms_ApplicationForms_ApplicationId",
                table: "FigmaPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_Stages_FigmaPrograms_ProgramId",
                table: "Stages");

            migrationBuilder.DropTable(
                name: "ApplicationsQuestions");

            migrationBuilder.DropIndex(
                name: "IX_Stages_ProgramId",
                table: "Stages");

            migrationBuilder.DropIndex(
                name: "IX_FigmaPrograms_ApplicationId",
                table: "FigmaPrograms");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "FigmaPrograms");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<int>(
                name: "PersonalInfoId",
                table: "ApplicationForms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
