using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class model_mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_Name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<int>(type: "integer", nullable: false),
                    E_Mail = table.Column<string>(type: "text", nullable: false),
                    First_Name = table.Column<string>(type: "text", nullable: false),
                    Last_Name = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ModelHayvanKabul",
                columns: table => new
                {
                    HayvanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Animal_Name = table.Column<string>(type: "text", nullable: false),
                    Animal_Age = table.Column<int>(type: "integer", nullable: false),
                    Animal_Gender = table.Column<string>(type: "text", nullable: false),
                    Animal_Kind = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ModelSahiplen",
                columns: table => new
                {
                    SahiplenmeID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HayvanID = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IsimSoyisim = table.Column<string>(type: "text", nullable: false),
                    TelNo = table.Column<int>(type: "integer", nullable: false),
                    Adres = table.Column<string>(type: "text", nullable: false),
                    Sifre = table.Column<int>(type: "integer", nullable: false),
                    SahiplenmeDurumu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "ModelHayvanKabul");

            migrationBuilder.DropTable(
                name: "ModelSahiplen");
        }
    }
}
