using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_Life.Migrations
{
    /// <inheritdoc />
    public partial class postGr1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostareGrups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostareGrups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostareGrups_Grups_GrupId",
                        column: x => x.GrupId,
                        principalTable: "Grups",
                        principalColumn: "GrupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostareGrups_Profiles_UserId",
                        column: x => x.UserId,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostareGrups_GrupId",
                table: "PostareGrups",
                column: "GrupId");

            migrationBuilder.CreateIndex(
                name: "IX_PostareGrups_UserId",
                table: "PostareGrups",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostareGrups");
        }
    }
}
