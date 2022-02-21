using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_1stAshish.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLACE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DETAILS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOBILE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOCATIONID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_customer_location_LOCATIONID",
                        column: x => x.LOCATIONID,
                        principalTable: "location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customer_LOCATIONID",
                table: "customer",
                column: "LOCATIONID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "location");
        }
    }
}
