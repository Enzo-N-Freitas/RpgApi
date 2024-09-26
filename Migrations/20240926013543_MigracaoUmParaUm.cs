using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitórias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitórias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitórias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitórias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitórias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitórias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitórias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitórias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 164, 143, 245, 211, 185, 186, 251, 212, 163, 156, 161, 118, 93, 235, 158, 120, 118, 225, 206, 25, 110, 7, 196, 65, 177, 155, 47, 77, 49, 201, 219, 185, 163, 239, 63, 195, 128, 245, 57, 53, 28, 159, 193, 94, 111, 147, 214, 154, 206, 113, 112, 11, 229, 243, 143, 246, 88, 120, 171, 248, 7, 18, 94 }, new byte[] { 150, 49, 181, 149, 232, 180, 100, 184, 86, 218, 53, 25, 248, 57, 240, 9, 154, 50, 118, 147, 122, 102, 227, 32, 122, 90, 9, 227, 26, 42, 89, 50, 191, 82, 219, 217, 217, 95, 105, 200, 134, 233, 67, 119, 159, 46, 195, 119, 138, 123, 123, 236, 80, 132, 234, 80, 12, 216, 137, 204, 172, 177, 161, 190, 63, 102, 64, 187, 100, 18, 40, 113, 179, 100, 141, 255, 24, 230, 76, 161, 152, 90, 89, 14, 100, 225, 247, 208, 10, 15, 60, 185, 164, 135, 145, 204, 93, 239, 72, 141, 41, 237, 135, 223, 159, 65, 92, 32, 221, 205, 75, 50, 91, 174, 83, 119, 106, 168, 89, 49, 127, 131, 250, 25, 236, 18, 76, 27 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitórias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 172, 133, 29, 211, 236, 230, 157, 97, 253, 154, 191, 239, 204, 61, 76, 127, 126, 80, 2, 246, 70, 38, 186, 109, 145, 233, 59, 215, 178, 60, 11, 219, 77, 17, 108, 137, 189, 119, 176, 177, 191, 165, 77, 119, 247, 74, 212, 81, 88, 178, 107, 227, 89, 113, 181, 67, 93, 4, 43, 125, 28, 164, 74, 122 }, new byte[] { 204, 207, 33, 237, 73, 88, 179, 118, 251, 254, 57, 184, 188, 42, 149, 131, 93, 1, 81, 132, 26, 12, 14, 186, 22, 115, 197, 168, 188, 51, 248, 0, 183, 136, 27, 40, 143, 149, 156, 135, 177, 77, 175, 126, 185, 140, 231, 53, 54, 17, 34, 181, 153, 27, 208, 224, 26, 16, 15, 64, 85, 244, 11, 44, 86, 192, 176, 136, 62, 96, 218, 34, 227, 169, 49, 118, 81, 136, 43, 60, 51, 44, 53, 252, 22, 1, 253, 43, 124, 70, 36, 12, 100, 26, 149, 145, 0, 235, 189, 112, 246, 255, 244, 83, 47, 42, 249, 62, 194, 177, 136, 34, 224, 102, 121, 121, 12, 2, 229, 208, 72, 195, 173, 117, 29, 200, 157, 143 } });
        }
    }
}
