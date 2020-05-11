using Microsoft.EntityFrameworkCore.Migrations;

namespace AfpaTinderCoreMvc.Migrations
{
    public partial class loisirsManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loisirs_Personnes_PersonneId",
                table: "Loisirs");

            migrationBuilder.DropIndex(
                name: "IX_Loisirs_PersonneId",
                table: "Loisirs");

            migrationBuilder.DropColumn(
                name: "PersonneId",
                table: "Loisirs");

            migrationBuilder.CreateTable(
                name: "PersonneLoisirs",
                columns: table => new
                {
                    LoisirId = table.Column<int>(nullable: false),
                    PersonneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonneLoisirs", x => new { x.PersonneId, x.LoisirId });
                    table.ForeignKey(
                        name: "FK_PersonneLoisirs_Loisirs_LoisirId",
                        column: x => x.LoisirId,
                        principalTable: "Loisirs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonneLoisirs_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonneLoisirs_LoisirId",
                table: "PersonneLoisirs",
                column: "LoisirId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonneLoisirs");

            migrationBuilder.AddColumn<int>(
                name: "PersonneId",
                table: "Loisirs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loisirs_PersonneId",
                table: "Loisirs",
                column: "PersonneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loisirs_Personnes_PersonneId",
                table: "Loisirs",
                column: "PersonneId",
                principalTable: "Personnes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
