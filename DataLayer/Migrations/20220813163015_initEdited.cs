using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class initEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accountings_AccountingTypes_AccountingTypeId",
                table: "Accountings");

            migrationBuilder.DropTable(
                name: "AccountingTypes");

            migrationBuilder.DropIndex(
                name: "IX_Accountings_AccountingTypeId",
                table: "Accountings");

            migrationBuilder.DropColumn(
                name: "AccountingTypeId",
                table: "Accountings");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Accountings",
                newName: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Accountings",
                newName: "TypeId");

            migrationBuilder.AddColumn<int>(
                name: "AccountingTypeId",
                table: "Accountings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AccountingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accountings_AccountingTypeId",
                table: "Accountings",
                column: "AccountingTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accountings_AccountingTypes_AccountingTypeId",
                table: "Accountings",
                column: "AccountingTypeId",
                principalTable: "AccountingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
