using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackHost.DB_Migration
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VahedId",
                table: "Vaheds");

            migrationBuilder.AlterColumn<int>(
                name: "VaziateSanad",
                table: "Vaheds",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "NahveForoosh",
                table: "Vaheds",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "DastgaheMoarrefiKonnande",
                table: "Vaheds",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Organizations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "SellMethods",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellMethods", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaheds_DastgaheMoarrefiKonnande",
                table: "Vaheds",
                column: "DastgaheMoarrefiKonnande");

            migrationBuilder.CreateIndex(
                name: "IX_Vaheds_NahveForoosh",
                table: "Vaheds",
                column: "NahveForoosh");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_Title",
                table: "Organizations",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SellMethods_Title",
                table: "SellMethods",
                column: "Title",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaheds_Organizations_DastgaheMoarrefiKonnande",
                table: "Vaheds",
                column: "DastgaheMoarrefiKonnande",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaheds_SellMethods_NahveForoosh",
                table: "Vaheds",
                column: "NahveForoosh",
                principalTable: "SellMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaheds_Organizations_DastgaheMoarrefiKonnande",
                table: "Vaheds");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaheds_SellMethods_NahveForoosh",
                table: "Vaheds");

            migrationBuilder.DropTable(
                name: "SellMethods");

            migrationBuilder.DropIndex(
                name: "IX_Vaheds_DastgaheMoarrefiKonnande",
                table: "Vaheds");

            migrationBuilder.DropIndex(
                name: "IX_Vaheds_NahveForoosh",
                table: "Vaheds");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_Title",
                table: "Organizations");

            migrationBuilder.AlterColumn<bool>(
                name: "VaziateSanad",
                table: "Vaheds",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NahveForoosh",
                table: "Vaheds",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "DastgaheMoarrefiKonnande",
                table: "Vaheds",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<int>(
                name: "VahedId",
                table: "Vaheds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
