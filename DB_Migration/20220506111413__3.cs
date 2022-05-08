using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackHost.DB_Migration
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EjareName",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estelam",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gharardad",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeyatNamayandegi",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Karshenasi",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Korooki",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadrakFeli",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadrakGhabli",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sanad",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SayerMostanadat",
                table: "Vaheds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "EntityId",
                table: "LogEntities",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Cities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Title",
                table: "Cities",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cities_Title",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "EjareName",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "Estelam",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "Gharardad",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "HeyatNamayandegi",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "Karshenasi",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "Korooki",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "MadrakFeli",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "MadrakGhabli",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "Sanad",
                table: "Vaheds");

            migrationBuilder.DropColumn(
                name: "SayerMostanadat",
                table: "Vaheds");

            migrationBuilder.AlterColumn<int>(
                name: "EntityId",
                table: "LogEntities",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
