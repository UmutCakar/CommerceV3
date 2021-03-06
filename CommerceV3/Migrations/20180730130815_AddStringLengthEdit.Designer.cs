﻿// <auto-generated />
using System;
using CommerceV3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommerceV3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180730130815_AddStringLengthEdit")]
    partial class AddStringLengthEdit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommerceV3.Models.Brand", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Logo")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CommerceV3.Models.Cart", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Owner")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("CommerceV3.Models.CartItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CartId");

                    b.Property<string>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("CommerceV3.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CommerceV3.Models.Menu", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("CommerceV3.Models.MenuItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPublished");

                    b.Property<string>("MenuId");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("ParentMenuItemId");

                    b.Property<int>("Position");

                    b.Property<string>("Target")
                        .HasMaxLength(200);

                    b.Property<string>("Url")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("ParentMenuItemId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("CommerceV3.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasMaxLength(750);

                    b.Property<bool>("IsInStock");

                    b.Property<bool>("IsNew");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<decimal>("OldPrice");

                    b.Property<string>("Photo")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("ShippingPriceInCityWide");

                    b.Property<decimal>("ShippingPriceInCountryWide");

                    b.Property<decimal>("ShippingPriceInWorldWide");

                    b.Property<string>("Slug")
                        .HasMaxLength(100);

                    b.Property<string>("SupplierId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CommerceV3.Models.ProductCategory", b =>
                {
                    b.Property<string>("ProductId");

                    b.Property<string>("CategoryId");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("CommerceV3.Models.Region", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("ParentRegionId");

                    b.Property<int>("RegionType");

                    b.HasKey("Id");

                    b.HasIndex("ParentRegionId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("CommerceV3.Models.Slide", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image")
                        .HasMaxLength(200);

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<int>("Position");

                    b.Property<string>("Target")
                        .HasMaxLength(200);

                    b.Property<string>("Url")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Slides");
                });

            modelBuilder.Entity("CommerceV3.Models.Supplier", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("RegionId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CommerceV3.Models.CartItem", b =>
                {
                    b.HasOne("CommerceV3.Models.Cart", "Cart")
                        .WithMany("CardItems")
                        .HasForeignKey("CartId");

                    b.HasOne("CommerceV3.Models.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("CommerceV3.Models.MenuItem", b =>
                {
                    b.HasOne("CommerceV3.Models.Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId");

                    b.HasOne("CommerceV3.Models.MenuItem", "ParentMenuItem")
                        .WithMany("ChildMenuItems")
                        .HasForeignKey("ParentMenuItemId");
                });

            modelBuilder.Entity("CommerceV3.Models.Product", b =>
                {
                    b.HasOne("CommerceV3.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("CommerceV3.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("CommerceV3.Models.ProductCategory", b =>
                {
                    b.HasOne("CommerceV3.Models.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CommerceV3.Models.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CommerceV3.Models.Region", b =>
                {
                    b.HasOne("CommerceV3.Models.Region", "ParentRegion")
                        .WithMany("ChildRegions")
                        .HasForeignKey("ParentRegionId");
                });

            modelBuilder.Entity("CommerceV3.Models.Supplier", b =>
                {
                    b.HasOne("CommerceV3.Models.Region", "Region")
                        .WithMany("Suppliers")
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
