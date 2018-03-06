﻿// <auto-generated />
using CodeNetCore.Data.EF;
using CodeNetCore.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CodeNetCore.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180306093216_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeNetCore.Data.Entites.Announcement", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(250);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.AnnouncementUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnnouncementId")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<bool?>("HasRead");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.ToTable("AnnouncementUsers");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BillStatus");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<Guid>("CustomerId")
                        .HasMaxLength(450);

                    b.Property<string>("CustomerMessage")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("CustomerMobile")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("PaymentMethod");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.BillDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BillId");

                    b.Property<int>("ColorId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("SizeId");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Config", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<string>("Address")
                        .HasMaxLength(250);

                    b.Property<string>("Analytics")
                        .HasMaxLength(200);

                    b.Property<string>("AppFacebook")
                        .HasMaxLength(200);

                    b.Property<string>("CodeChat")
                        .HasMaxLength(500);

                    b.Property<string>("Color")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(250);

                    b.Property<string>("Content");

                    b.Property<bool?>("Coppy");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FanpageGoogle")
                        .HasMaxLength(250);

                    b.Property<string>("FanpageYoutube")
                        .HasMaxLength(250);

                    b.Property<string>("FanpgeFacebook")
                        .HasMaxLength(250);

                    b.Property<string>("Fax")
                        .HasMaxLength(100);

                    b.Property<string>("GeoMeta")
                        .HasMaxLength(500);

                    b.Property<string>("Host")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Hotline")
                        .HasMaxLength(100);

                    b.Property<string>("ImageFavicon")
                        .HasMaxLength(250);

                    b.Property<string>("ImageLogo")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Mobile")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<string>("PassMail")
                        .HasMaxLength(250);

                    b.Property<bool?>("Popup");

                    b.Property<int?>("Port");

                    b.Property<string>("Slogan")
                        .HasMaxLength(100);

                    b.Property<bool?>("Social");

                    b.Property<string>("TimeOut")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UserMail")
                        .HasMaxLength(100);

                    b.Property<string>("WebMasterTool")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Contact", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(250);

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<double?>("Lat");

                    b.Property<double?>("Lng");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Other");

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<int>("Status");

                    b.Property<string>("Website")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("Message")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Function", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IconCss");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("Ord");

                    b.Property<string>("ParentId")
                        .HasMaxLength(128);

                    b.Property<int>("Status");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Language", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Active");

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Resources");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Active");

                    b.Property<int?>("Age");

                    b.Property<string>("Alias")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Code")
                        .HasMaxLength(500);

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("DescriptionMeta")
                        .HasMaxLength(300);

                    b.Property<bool?>("HomeFlag");

                    b.Property<string>("ImageDetail")
                        .HasMaxLength(250);

                    b.Property<string>("ImageThumbs")
                        .HasMaxLength(250);

                    b.Property<string>("Info");

                    b.Property<string>("KeywordMeta")
                        .HasMaxLength(300);

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.Property<bool?>("New");

                    b.Property<string>("NotePrice")
                        .HasMaxLength(250);

                    b.Property<int>("Ord");

                    b.Property<string>("Parameter");

                    b.Property<decimal?>("Price")
                        .IsRequired();

                    b.Property<decimal?>("PriceSale")
                        .IsRequired();

                    b.Property<bool?>("ProductSale");

                    b.Property<string>("Sale");

                    b.Property<string>("Size")
                        .HasMaxLength(250);

                    b.Property<int>("Status");

                    b.Property<string>("Tag")
                        .HasMaxLength(255);

                    b.Property<string>("TitleMeta")
                        .HasMaxLength(200);

                    b.Property<bool?>("Vat");

                    b.Property<int?>("ViewCount");

                    b.Property<int>("Warranty");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias")
                        .HasMaxLength(255);

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DescriptionMeta")
                        .HasMaxLength(255);

                    b.Property<bool?>("HomeFlag");

                    b.Property<string>("Icon")
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<string>("KeywordMeta")
                        .HasMaxLength(255);

                    b.Property<int>("LanguageId");

                    b.Property<string>("Name");

                    b.Property<int>("Ord");

                    b.Property<int?>("ParentId");

                    b.Property<int>("Status");

                    b.Property<string>("TitleMeta")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.ProductColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ColorId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductColors");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption")
                        .HasMaxLength(250);

                    b.Property<string>("Image")
                        .HasMaxLength(250);

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.ProductSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("ProductSizes");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.ProductTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<string>("TagId")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Tag", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId");

                    b.Property<string>("UserId");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Announcement", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.AnnouncementUser", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.Announcement", "Announcement")
                        .WithMany("AnnouncementUsers")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Bill", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.BillDetail", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNetCore.Data.Entites.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNetCore.Data.Entites.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNetCore.Data.Entites.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.Product", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.ProductColor", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNetCore.Data.Entites.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.ProductImage", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNetCore.Data.Entites.ProductTag", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.Product", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNetCore.Data.Entites.Tag", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNetCore.Data.Entites.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("CodeNetCore.Data.Entites.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
