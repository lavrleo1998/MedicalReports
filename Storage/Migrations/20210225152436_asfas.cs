using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class asfas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Templates_ProtocolParameters_ProtocolParameterId",
                table: "Templates");

            migrationBuilder.DropTable(
                name: "ProtocolParameters");

            migrationBuilder.DropIndex(
                name: "IX_Templates_ProtocolParameterId",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "ProtocolParameterId",
                table: "Templates");

            migrationBuilder.AddColumn<long>(
                name: "ParamId",
                table: "Templates",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Params",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateDelete = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Params", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Templates_ParamId",
                table: "Templates",
                column: "ParamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Params_ParamId",
                table: "Templates",
                column: "ParamId",
                principalTable: "Params",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Params_ParamId",
                table: "Templates");

            migrationBuilder.DropTable(
                name: "Params");

            migrationBuilder.DropIndex(
                name: "IX_Templates_ParamId",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "ParamId",
                table: "Templates");

            migrationBuilder.AddColumn<long>(
                name: "ProtocolParameterId",
                table: "Templates",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ProtocolParameters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDelete = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolParameters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Templates_ProtocolParameterId",
                table: "Templates",
                column: "ProtocolParameterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_ProtocolParameters_ProtocolParameterId",
                table: "Templates",
                column: "ProtocolParameterId",
                principalTable: "ProtocolParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
