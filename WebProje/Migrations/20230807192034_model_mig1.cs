using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class model_mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SahiplenmeDurumu",
                table: "ModelSahiplen");

            migrationBuilder.DropColumn(
                name: "User_ID",
                table: "ModelSahiplen");

            migrationBuilder.AlterColumn<string>(
                name: "Sifre",
                table: "ModelSahiplen",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sifre",
                table: "ModelSahiplen",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "SahiplenmeDurumu",
                table: "ModelSahiplen",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "User_ID",
                table: "ModelSahiplen",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
