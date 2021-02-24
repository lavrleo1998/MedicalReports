using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class newTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Templates_ProtocolParameters_ProtocolParameterId",
                table: "Templates");

            migrationBuilder.AlterColumn<long>(
                name: "ProtocolParameterId",
                table: "Templates",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_ProtocolParameters_ProtocolParameterId",
                table: "Templates",
                column: "ProtocolParameterId",
                principalTable: "ProtocolParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Templates_ProtocolParameters_ProtocolParameterId",
                table: "Templates");

            migrationBuilder.AlterColumn<long>(
                name: "ProtocolParameterId",
                table: "Templates",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_ProtocolParameters_ProtocolParameterId",
                table: "Templates",
                column: "ProtocolParameterId",
                principalTable: "ProtocolParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
