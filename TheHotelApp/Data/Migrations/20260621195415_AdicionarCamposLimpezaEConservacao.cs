using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheHotelApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCamposLimpezaEConservacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Available",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Conservacao",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "StatusLimpeza",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conservacao",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "StatusLimpeza",
                table: "Rooms");

            migrationBuilder.AlterColumn<bool>(
                name: "Available",
                table: "Rooms",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
