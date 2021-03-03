using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class ydstvkuvu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrganId",
                table: "Params",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Organs",
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
                    table.PrimaryKey("PK_Organs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Params_OrganId",
                table: "Params",
                column: "OrganId");

            migrationBuilder.AddForeignKey(
                name: "FK_Params_Organs_OrganId",
                table: "Params",
                column: "OrganId",
                principalTable: "Organs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Params_Organs_OrganId",
                table: "Params");

            migrationBuilder.DropTable(
                name: "Organs");

            migrationBuilder.DropIndex(
                name: "IX_Params_OrganId",
                table: "Params");

            migrationBuilder.DropColumn(
                name: "OrganId",
                table: "Params");
        }
    }
}
