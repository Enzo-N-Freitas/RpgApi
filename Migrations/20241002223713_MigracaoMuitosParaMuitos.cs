using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 62, 20, 250, 244, 216, 225, 140, 47, 5, 28, 228, 18, 132, 28, 131, 84, 30, 187, 221, 7, 127, 209, 101, 226, 164, 164, 135, 10, 18, 128, 211, 115, 142, 208, 253, 28, 242, 226, 165, 145, 140, 47, 113, 212, 247, 68, 180, 113, 198, 0, 72, 152, 34, 164, 0, 235, 22, 7, 15, 246, 235, 183, 6, 133 }, new byte[] { 158, 207, 222, 37, 229, 16, 160, 26, 48, 199, 186, 80, 66, 225, 34, 94, 243, 62, 229, 44, 163, 255, 39, 76, 36, 181, 50, 21, 136, 232, 192, 154, 22, 73, 169, 115, 160, 154, 225, 205, 12, 42, 153, 95, 168, 195, 118, 96, 214, 2, 107, 8, 142, 81, 160, 227, 155, 34, 172, 170, 245, 56, 85, 118, 184, 234, 198, 129, 94, 177, 10, 226, 131, 24, 140, 133, 36, 16, 92, 168, 52, 114, 98, 66, 19, 237, 137, 50, 95, 100, 112, 188, 19, 73, 160, 201, 47, 44, 134, 197, 16, 82, 152, 84, 90, 43, 118, 104, 249, 157, 178, 239, 181, 30, 43, 123, 206, 229, 252, 45, 216, 62, 141, 166, 90, 132, 59, 0 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 164, 143, 245, 211, 185, 186, 251, 212, 163, 156, 161, 118, 93, 235, 158, 120, 118, 225, 206, 25, 110, 7, 196, 65, 177, 155, 47, 77, 49, 201, 219, 185, 163, 239, 63, 195, 128, 245, 57, 53, 28, 159, 193, 94, 111, 147, 214, 154, 206, 113, 112, 11, 229, 243, 143, 246, 88, 120, 171, 248, 7, 18, 94 }, new byte[] { 150, 49, 181, 149, 232, 180, 100, 184, 86, 218, 53, 25, 248, 57, 240, 9, 154, 50, 118, 147, 122, 102, 227, 32, 122, 90, 9, 227, 26, 42, 89, 50, 191, 82, 219, 217, 217, 95, 105, 200, 134, 233, 67, 119, 159, 46, 195, 119, 138, 123, 123, 236, 80, 132, 234, 80, 12, 216, 137, 204, 172, 177, 161, 190, 63, 102, 64, 187, 100, 18, 40, 113, 179, 100, 141, 255, 24, 230, 76, 161, 152, 90, 89, 14, 100, 225, 247, 208, 10, 15, 60, 185, 164, 135, 145, 204, 93, 239, 72, 141, 41, 237, 135, 223, 159, 65, 92, 32, 221, 205, 75, 50, 91, 174, 83, 119, 106, 168, 89, 49, 127, 131, 250, 25, 236, 18, 76, 27 } });
        }
    }
}
