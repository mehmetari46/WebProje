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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    User_Name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    E_Mail = table.Column<string>(type: "text", nullable: false),
                    First_Name = table.Column<string>(type: "text", nullable: false),
                    Last_Name = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "modelHayvanKabul",
                columns: table => new
                {
                    HayvanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    Animal_Name = table.Column<string>(type: "text", nullable: false),
                    Animal_Age = table.Column<int>(type: "integer", nullable: false),
                    Animal_Gender = table.Column<string>(type: "text", nullable: false),
                    Animal_Kind = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelHayvanKabul", x => x.HayvanID);
                });

            migrationBuilder.CreateTable(
                name: "ModelSahiplen",
                columns: table => new
                {
                    SahiplenmeID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    HayvanID = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IsimSoyisim = table.Column<string>(type: "text", nullable: false),
                    TelNo = table.Column<string>(type: "text", nullable: false),
                    Adres = table.Column<string>(type: "text", nullable: false),
                    Sifre = table.Column<int>(type: "integer", nullable: false),
                    SahiplenmeDurumu = table.Column<string>(type: "text", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelSahiplen", x => x.SahiplenmeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "modelHayvanKabul");

            migrationBuilder.DropTable(
                name: "ModelSahiplen");
        }
    }
}
