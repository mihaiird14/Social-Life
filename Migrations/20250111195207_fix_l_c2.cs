using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_Life.Migrations
{
    /// <inheritdoc />
    public partial class fix_l_c2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostsComments_Postari_PostId",
                table: "PostsComments");

            migrationBuilder.DropForeignKey(
                name: "FK_PostsComments_Profiles_Id_User",
                table: "PostsComments");

            migrationBuilder.AddForeignKey(
                name: "FK_PostsComments_Postari_PostId",
                table: "PostsComments",
                column: "PostId",
                principalTable: "Postari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostsComments_Profiles_Id_User",
                table: "PostsComments",
                column: "Id_User",
                principalTable: "Profiles",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostsComments_Postari_PostId",
                table: "PostsComments");

            migrationBuilder.DropForeignKey(
                name: "FK_PostsComments_Profiles_Id_User",
                table: "PostsComments");

            migrationBuilder.AddForeignKey(
                name: "FK_PostsComments_Postari_PostId",
                table: "PostsComments",
                column: "PostId",
                principalTable: "Postari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostsComments_Profiles_Id_User",
                table: "PostsComments",
                column: "Id_User",
                principalTable: "Profiles",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
