﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Social_Life.Data;

#nullable disable

namespace Social_Life.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Social_Life.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Social_Life.Models.Follow", b =>
                {
                    b.Property<int>("FollowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FollowId"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id_Urmarit")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Urmaritor")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FollowId");

                    b.HasIndex("Id_Urmarit");

                    b.HasIndex("Id_Urmaritor");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("Social_Life.Models.Grup", b =>
                {
                    b.Property<int>("GrupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GrupId"));

                    b.Property<string>("AdminGrupId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataGr")
                        .HasColumnType("datetime2");

                    b.Property<string>("GrupImagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GrupPublic")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileId_User")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GrupId");

                    b.HasIndex("ProfileId_User");

                    b.ToTable("Grups");
                });

            modelBuilder.Entity("Social_Life.Models.Grup_Membrii", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GrupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.HasKey("Id", "UserId", "GrupId");

                    b.HasIndex("GrupId");

                    b.HasIndex("UserId");

                    b.ToTable("Grup_Membriis");
                });

            modelBuilder.Entity("Social_Life.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"));

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id_User")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_User2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotificationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationId");

                    b.HasIndex("Id_User");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Social_Life.Models.PostCommentsLike", b =>
                {
                    b.Property<int>("PostCMLK_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostCMLK_Id"));

                    b.Property<int>("Comment_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("User_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostCMLK_Id");

                    b.HasIndex("Comment_Id");

                    b.HasIndex("User_id");

                    b.ToTable("PostCommentsLikes");
                });

            modelBuilder.Entity("Social_Life.Models.Postare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Arhivat")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Imagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrComentarii")
                        .HasColumnType("int");

                    b.Property<int>("NrLikePostare")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Postari");
                });

            modelBuilder.Entity("Social_Life.Models.PostareLike2", b =>
                {
                    b.Property<int>("PostareLikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostareLikeId"));

                    b.Property<DateTime>("LikeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostareId")
                        .HasColumnType("int");

                    b.Property<string>("ProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostareLikeId");

                    b.HasIndex("PostareId");

                    b.HasIndex("ProfileId");

                    b.ToTable("PostareLikes2");
                });

            modelBuilder.Entity("Social_Life.Models.PostsComment", b =>
                {
                    b.Property<int>("PostCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostCommentId"));

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Edited")
                        .HasColumnType("bit");

                    b.Property<string>("Id_User")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("PostCommentId");

                    b.HasIndex("Id_User");

                    b.HasIndex("PostId");

                    b.ToTable("PostsComments");
                });

            modelBuilder.Entity("Social_Life.Models.Profile", b =>
                {
                    b.Property<string>("Id_User")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProfilPublic")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_User");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Social_Life.Models.Thread2", b =>
                {
                    b.Property<int>("ThreadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThreadId"));

                    b.Property<bool>("Arhivat")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Edited")
                        .HasColumnType("bit");

                    b.Property<string>("Id_User")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ThreadComments")
                        .HasColumnType("int");

                    b.Property<int>("ThreadLikes")
                        .HasColumnType("int");

                    b.Property<string>("ThreadText")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ThreadId");

                    b.HasIndex("Id_User");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("Social_Life.Models.ThreadComment", b =>
                {
                    b.Property<int>("ThreadCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThreadCommentId"));

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Edited")
                        .HasColumnType("bit");

                    b.Property<string>("Id_User")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("ThreadId")
                        .HasColumnType("int");

                    b.HasKey("ThreadCommentId");

                    b.HasIndex("Id_User");

                    b.HasIndex("ThreadId");

                    b.ToTable("ThreadComments");
                });

            modelBuilder.Entity("Social_Life.Models.ThreadCommentsLike", b =>
                {
                    b.Property<int>("ThreadCMLK_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThreadCMLK_Id"));

                    b.Property<int>("Comment_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("User_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ThreadCMLK_Id");

                    b.HasIndex("Comment_Id");

                    b.HasIndex("User_id");

                    b.ToTable("ThreadCommentsLikes");
                });

            modelBuilder.Entity("Social_Life.Models.ThreadLike", b =>
                {
                    b.Property<int>("ThreadLikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThreadLikeId"));

                    b.Property<DateTime>("LikeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ThreadId")
                        .HasColumnType("int");

                    b.HasKey("ThreadLikeId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("ThreadId");

                    b.ToTable("ThreadLikes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Social_Life.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Social_Life.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Social_Life.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Social_Life.Models.Follow", b =>
                {
                    b.HasOne("Social_Life.Models.Profile", "Urmarit")
                        .WithMany("Urmaritori")
                        .HasForeignKey("Id_Urmarit")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.Profile", "Urmaritor")
                        .WithMany("Urmariti")
                        .HasForeignKey("Id_Urmaritor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Urmarit");

                    b.Navigation("Urmaritor");
                });

            modelBuilder.Entity("Social_Life.Models.Grup", b =>
                {
                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Social_Life.Models.Grup_Membrii", b =>
                {
                    b.HasOne("Social_Life.Models.Grup", "Grup")
                        .WithMany("GrupMembrii")
                        .HasForeignKey("GrupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("GrupuriMembru")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Grup");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Social_Life.Models.Notification", b =>
                {
                    b.HasOne("Social_Life.Models.Profile", "Profile1")
                        .WithMany("Notifications")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Profile1");
                });

            modelBuilder.Entity("Social_Life.Models.PostCommentsLike", b =>
                {
                    b.HasOne("Social_Life.Models.PostsComment", "PostsComment")
                        .WithMany("Post_Comment_Likes")
                        .HasForeignKey("Comment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("Post_Com_Likes")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PostsComment");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Social_Life.Models.Postare", b =>
                {
                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("Postari")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Social_Life.Models.PostareLike2", b =>
                {
                    b.HasOne("Social_Life.Models.Postare", "Postare")
                        .WithMany("PostareLike")
                        .HasForeignKey("PostareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("LikedPosts")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Postare");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Social_Life.Models.PostsComment", b =>
                {
                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("PostsComments")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.Postare", "Postare")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Postare");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Social_Life.Models.Profile", b =>
                {
                    b.HasOne("Social_Life.Models.ApplicationUser", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Social_Life.Models.Profile", "Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Social_Life.Models.Thread2", b =>
                {
                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("Threads")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Social_Life.Models.ThreadComment", b =>
                {
                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("Comments")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.Thread2", "Thread2")
                        .WithMany("Comments")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Thread2");
                });

            modelBuilder.Entity("Social_Life.Models.ThreadCommentsLike", b =>
                {
                    b.HasOne("Social_Life.Models.ThreadComment", "ThreadComment")
                        .WithMany("Comment_Likes")
                        .HasForeignKey("Comment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("Comment_Likes")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("ThreadComment");
                });

            modelBuilder.Entity("Social_Life.Models.ThreadLike", b =>
                {
                    b.HasOne("Social_Life.Models.Profile", "Profile")
                        .WithMany("LikedThreads")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Social_Life.Models.Thread2", "Thread")
                        .WithMany("Likes")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Thread");
                });

            modelBuilder.Entity("Social_Life.Models.ApplicationUser", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("Social_Life.Models.Grup", b =>
                {
                    b.Navigation("GrupMembrii");
                });

            modelBuilder.Entity("Social_Life.Models.Postare", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PostareLike");
                });

            modelBuilder.Entity("Social_Life.Models.PostsComment", b =>
                {
                    b.Navigation("Post_Comment_Likes");
                });

            modelBuilder.Entity("Social_Life.Models.Profile", b =>
                {
                    b.Navigation("Comment_Likes");

                    b.Navigation("Comments");

                    b.Navigation("GrupuriMembru");

                    b.Navigation("LikedPosts");

                    b.Navigation("LikedThreads");

                    b.Navigation("Notifications");

                    b.Navigation("Post_Com_Likes");

                    b.Navigation("Postari");

                    b.Navigation("PostsComments");

                    b.Navigation("Threads");

                    b.Navigation("Urmariti");

                    b.Navigation("Urmaritori");
                });

            modelBuilder.Entity("Social_Life.Models.Thread2", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("Social_Life.Models.ThreadComment", b =>
                {
                    b.Navigation("Comment_Likes");
                });
#pragma warning restore 612, 618
        }
    }
}
