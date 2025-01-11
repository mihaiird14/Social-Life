using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_Life.Migrations
{
    /// <inheritdoc />
    public partial class fix_l_c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostCommentsLikes_PostsComments_Comment_Id",
                table: "PostCommentsLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_PostCommentsLikes_Profiles_User_id",
                table: "PostCommentsLikes");

            migrationBuilder.AddForeignKey(
                name: "FK_PostCommentsLikes_PostsComments_Comment_Id",
                table: "PostCommentsLikes",
                column: "Comment_Id",
                principalTable: "PostsComments",
                principalColumn: "PostCommentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostCommentsLikes_Profiles_User_id",
                table: "PostCommentsLikes",
                column: "User_id",
                principalTable: "Profiles",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostCommentsLikes_PostsComments_Comment_Id",
                table: "PostCommentsLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_PostCommentsLikes_Profiles_User_id",
                table: "PostCommentsLikes");

            migrationBuilder.AddForeignKey(
                name: "FK_PostCommentsLikes_PostsComments_Comment_Id",
                table: "PostCommentsLikes",
                column: "Comment_Id",
                principalTable: "PostsComments",
                principalColumn: "PostCommentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostCommentsLikes_Profiles_User_id",
                table: "PostCommentsLikes",
                column: "User_id",
                principalTable: "Profiles",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
