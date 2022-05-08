using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackHost.DB_Migration
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaheds_Cities_CityId",
                table: "Vaheds");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaheds_Organizations_DastgaheMoarrefiKonnande",
                table: "Vaheds");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaheds_SellMethods_NahveForoosh",
                table: "Vaheds");

            migrationBuilder.AlterColumn<long>(
                name: "NahveForoosh",
                table: "Vaheds",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "DastgaheMoarrefiKonnande",
                table: "Vaheds",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CityId",
                table: "Vaheds",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaheds_Cities_CityId",
                table: "Vaheds",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaheds_Organizations_DastgaheMoarrefiKonnande",
                table: "Vaheds",
                column: "DastgaheMoarrefiKonnande",
                principalTable: "Organizations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaheds_SellMethods_NahveForoosh",
                table: "Vaheds",
                column: "NahveForoosh",
                principalTable: "SellMethods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaheds_Cities_CityId",
                table: "Vaheds");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaheds_Organizations_DastgaheMoarrefiKonnande",
                table: "Vaheds");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaheds_SellMethods_NahveForoosh",
                table: "Vaheds");

            migrationBuilder.AlterColumn<long>(
                name: "NahveForoosh",
                table: "Vaheds",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DastgaheMoarrefiKonnande",
                table: "Vaheds",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CityId",
                table: "Vaheds",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaheds_Cities_CityId",
                table: "Vaheds",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
