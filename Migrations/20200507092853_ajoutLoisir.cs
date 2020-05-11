using Microsoft.EntityFrameworkCore.Migrations;

namespace AfpaTinderCoreMvc.Migrations
{
    public partial class ajoutLoisir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loisirs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(maxLength: 100, nullable: true),
                    PersonneId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loisirs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loisirs_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loisirs_PersonneId",
                table: "Loisirs",
                column: "PersonneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loisirs");
        }
    }
}
