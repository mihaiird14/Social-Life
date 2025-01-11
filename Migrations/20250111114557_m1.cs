using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_Life.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id_User = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfilPublic = table.Column<bool>(type: "bit", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id_User);
                    table.ForeignKey(
                        name: "FK_Profiles_AspNetUsers_Id_User",
                        column: x => x.Id_User,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Follows",
                columns: table => new
                {
                    FollowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Urmaritor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_Urmarit = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follows", x => x.FollowId);
                    table.ForeignKey(
                        name: "FK_Follows_Profiles_Id_Urmarit",
                        column: x => x.Id_Urmarit,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Follows_Profiles_Id_Urmaritor",
                        column: x => x.Id_Urmaritor,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grups",
                columns: table => new
                {
                    GrupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminGrupId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileId_User = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GrupImagine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupPublic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grups", x => x.GrupId);
                    table.ForeignKey(
                        name: "FK_Grups_Profiles_ProfileId_User",
                        column: x => x.ProfileId_User,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_User = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_User2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    Accepted = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_Profiles_Id_User",
                        column: x => x.Id_User,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Postari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Imagine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NrLikePostare = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NrComentarii = table.Column<int>(type: "int", nullable: false),
                    Arhivat = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postari_Profiles_UserId",
                        column: x => x.UserId,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Threads",
                columns: table => new
                {
                    ThreadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_User = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThreadText = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ThreadLikes = table.Column<int>(type: "int", nullable: false),
                    ThreadComments = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<bool>(type: "bit", nullable: false),
                    Arhivat = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threads", x => x.ThreadId);
                    table.ForeignKey(
                        name: "FK_Threads_Profiles_Id_User",
                        column: x => x.Id_User,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grup_Membriis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GrupId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grup_Membriis", x => new { x.Id, x.UserId, x.GrupId });
                    table.ForeignKey(
                        name: "FK_Grup_Membriis_Grups_GrupId",
                        column: x => x.GrupId,
                        principalTable: "Grups",
                        principalColumn: "GrupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grup_Membriis_Profiles_UserId",
                        column: x => x.UserId,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostareLikes2",
                columns: table => new
                {
                    PostareLikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostareId = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LikeDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostareLikes2", x => x.PostareLikeId);
                    table.ForeignKey(
                        name: "FK_PostareLikes2_Postari_PostareId",
                        column: x => x.PostareId,
                        principalTable: "Postari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostareLikes2_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostsComments",
                columns: table => new
                {
                    PostCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Id_User = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<bool>(type: "bit", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostsComments", x => x.PostCommentId);
                    table.ForeignKey(
                        name: "FK_PostsComments_Postari_PostId",
                        column: x => x.PostId,
                        principalTable: "Postari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostsComments_Profiles_Id_User",
                        column: x => x.Id_User,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThreadComments",
                columns: table => new
                {
                    ThreadCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThreadId = table.Column<int>(type: "int", nullable: false),
                    Id_User = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<bool>(type: "bit", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadComments", x => x.ThreadCommentId);
                    table.ForeignKey(
                        name: "FK_ThreadComments_Profiles_Id_User",
                        column: x => x.Id_User,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThreadComments_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "ThreadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThreadLikes",
                columns: table => new
                {
                    ThreadLikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThreadId = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LikeDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadLikes", x => x.ThreadLikeId);
                    table.ForeignKey(
                        name: "FK_ThreadLikes_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThreadLikes_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "ThreadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostCommentsLikes",
                columns: table => new
                {
                    PostCMLK_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment_Id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCommentsLikes", x => x.PostCMLK_Id);
                    table.ForeignKey(
                        name: "FK_PostCommentsLikes_PostsComments_Comment_Id",
                        column: x => x.Comment_Id,
                        principalTable: "PostsComments",
                        principalColumn: "PostCommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostCommentsLikes_Profiles_User_id",
                        column: x => x.User_id,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThreadCommentsLikes",
                columns: table => new
                {
                    ThreadCMLK_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment_Id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadCommentsLikes", x => x.ThreadCMLK_Id);
                    table.ForeignKey(
                        name: "FK_ThreadCommentsLikes_Profiles_User_id",
                        column: x => x.User_id,
                        principalTable: "Profiles",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThreadCommentsLikes_ThreadComments_Comment_Id",
                        column: x => x.Comment_Id,
                        principalTable: "ThreadComments",
                        principalColumn: "ThreadCommentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_Id_Urmarit",
                table: "Follows",
                column: "Id_Urmarit");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_Id_Urmaritor",
                table: "Follows",
                column: "Id_Urmaritor");

            migrationBuilder.CreateIndex(
                name: "IX_Grup_Membriis_GrupId",
                table: "Grup_Membriis",
                column: "GrupId");

            migrationBuilder.CreateIndex(
                name: "IX_Grup_Membriis_UserId",
                table: "Grup_Membriis",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Grups_ProfileId_User",
                table: "Grups",
                column: "ProfileId_User");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_Id_User",
                table: "Notifications",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_PostareLikes2_PostareId",
                table: "PostareLikes2",
                column: "PostareId");

            migrationBuilder.CreateIndex(
                name: "IX_PostareLikes2_ProfileId",
                table: "PostareLikes2",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Postari_UserId",
                table: "Postari",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostCommentsLikes_Comment_Id",
                table: "PostCommentsLikes",
                column: "Comment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostCommentsLikes_User_id",
                table: "PostCommentsLikes",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_PostsComments_Id_User",
                table: "PostsComments",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_PostsComments_PostId",
                table: "PostsComments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadComments_Id_User",
                table: "ThreadComments",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadComments_ThreadId",
                table: "ThreadComments",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadCommentsLikes_Comment_Id",
                table: "ThreadCommentsLikes",
                column: "Comment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadCommentsLikes_User_id",
                table: "ThreadCommentsLikes",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadLikes_ProfileId",
                table: "ThreadLikes",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadLikes_ThreadId",
                table: "ThreadLikes",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_Id_User",
                table: "Threads",
                column: "Id_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Follows");

            migrationBuilder.DropTable(
                name: "Grup_Membriis");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PostareLikes2");

            migrationBuilder.DropTable(
                name: "PostCommentsLikes");

            migrationBuilder.DropTable(
                name: "ThreadCommentsLikes");

            migrationBuilder.DropTable(
                name: "ThreadLikes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Grups");

            migrationBuilder.DropTable(
                name: "PostsComments");

            migrationBuilder.DropTable(
                name: "ThreadComments");

            migrationBuilder.DropTable(
                name: "Postari");

            migrationBuilder.DropTable(
                name: "Threads");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
