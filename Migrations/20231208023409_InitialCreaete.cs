using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lunas_mini_aussies_.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreaete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CName = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    LName = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    phone = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Puppies",
                columns: table => new
                {
                    PuppyID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Height = table.Column<double>(type: "REAL", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Temp = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    mom = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    dad = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    ClientID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puppies", x => x.PuppyID);
                    table.ForeignKey(
                        name: "FK_Puppies_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Puppies_ClientID",
                table: "Puppies",
                column: "ClientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Puppies");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
