﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManagement.Model;

#nullable disable

namespace StockManagement.Migrations
{
    [DbContext(typeof(StockDBContext))]
    partial class StockDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StockManagement.Model.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("StockManagement.Model.Gari1", b =>
                {
                    b.Property<int>("Gari1Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gari1Id"), 1L, 1);

                    b.Property<int>("Gari1MasterId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Receive")
                        .HasColumnType("int");

                    b.Property<int>("Return")
                        .HasColumnType("int");

                    b.Property<int>("Sales")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Gari1Id");

                    b.HasIndex("Gari1MasterId");

                    b.HasIndex("ProductId");

                    b.ToTable("gari1");
                });

            modelBuilder.Entity("StockManagement.Model.Gari1Master_tbl", b =>
                {
                    b.Property<int>("Gari1MasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gari1MasterId"), 1L, 1);

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalReceive")
                        .HasColumnType("int");

                    b.Property<int>("TotalReturn")
                        .HasColumnType("int");

                    b.Property<int>("TotalSales")
                        .HasColumnType("int");

                    b.HasKey("Gari1MasterId");

                    b.ToTable("gari1Master_Tbl");
                });

            modelBuilder.Entity("StockManagement.Model.Gari2", b =>
                {
                    b.Property<int>("Gari2Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gari2Id"), 1L, 1);

                    b.Property<int>("Gari2MasterId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Receive")
                        .HasColumnType("int");

                    b.Property<int>("Return")
                        .HasColumnType("int");

                    b.Property<int>("Sales")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Gari2Id");

                    b.HasIndex("Gari2MasterId");

                    b.HasIndex("ProductId");

                    b.ToTable("gari2");
                });

            modelBuilder.Entity("StockManagement.Model.Gari2Master_tbl", b =>
                {
                    b.Property<int>("Gari2MasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gari2MasterId"), 1L, 1);

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalReceive")
                        .HasColumnType("int");

                    b.Property<int>("TotalReturn")
                        .HasColumnType("int");

                    b.Property<int>("TotalSales")
                        .HasColumnType("int");

                    b.HasKey("Gari2MasterId");

                    b.ToTable("gari2Master_Tbl");
                });

            modelBuilder.Entity("StockManagement.Model.Gari3", b =>
                {
                    b.Property<int>("Gari3Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gari3Id"), 1L, 1);

                    b.Property<int>("Gari3MasterId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Receive")
                        .HasColumnType("int");

                    b.Property<int>("Return")
                        .HasColumnType("int");

                    b.Property<int>("Sales")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Gari3Id");

                    b.HasIndex("Gari3MasterId");

                    b.HasIndex("ProductId");

                    b.ToTable("gari3");
                });

            modelBuilder.Entity("StockManagement.Model.Gari3Master_tbl", b =>
                {
                    b.Property<int>("Gari3MasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gari3MasterId"), 1L, 1);

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalReceive")
                        .HasColumnType("int");

                    b.Property<int>("TotalReturn")
                        .HasColumnType("int");

                    b.Property<int>("TotalSales")
                        .HasColumnType("int");

                    b.HasKey("Gari3MasterId");

                    b.ToTable("gari3Master_Tbl");
                });

            modelBuilder.Entity("StockManagement.Model.IglooIceCream", b =>
                {
                    b.Property<int>("IglooIceCreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IglooIceCreamId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Dumping")
                        .HasColumnType("int");

                    b.Property<int?>("Eja")
                        .HasColumnType("int");

                    b.Property<int>("IglooIceCreamMasterId")
                        .HasColumnType("int");

                    b.Property<int?>("NewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Receive")
                        .HasColumnType("int");

                    b.Property<int?>("Remaining")
                        .HasColumnType("int");

                    b.Property<int?>("SalesQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IglooIceCreamId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("IglooIceCreamMasterId");

                    b.HasIndex("ProductId");

                    b.ToTable("iglooIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.IglooIceCreamMaster_tbl", b =>
                {
                    b.Property<int>("IglooIceCreamMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IglooIceCreamMasterId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GrandTotal")
                        .HasColumnType("int");

                    b.Property<decimal?>("GrandTotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalDumping")
                        .HasColumnType("int");

                    b.Property<int?>("TotalEja")
                        .HasColumnType("int");

                    b.Property<int?>("TotalNewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalReceive")
                        .HasColumnType("int");

                    b.Property<int?>("TotalRemaining")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSalesQuantity")
                        .HasColumnType("int");

                    b.HasKey("IglooIceCreamMasterId");

                    b.ToTable("iglooIceCreamMaster_Tbl");
                });

            modelBuilder.Entity("StockManagement.Model.KaziFarmFood", b =>
                {
                    b.Property<int>("KaziFarmFoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KaziFarmFoodId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Dumping")
                        .HasColumnType("int");

                    b.Property<int?>("Eja")
                        .HasColumnType("int");

                    b.Property<int>("KaziFarmFoodMasterId")
                        .HasColumnType("int");

                    b.Property<int?>("NewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Receive")
                        .HasColumnType("int");

                    b.Property<int?>("Remaining")
                        .HasColumnType("int");

                    b.Property<int?>("SalesQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("KaziFarmFoodId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("KaziFarmFoodMasterId");

                    b.HasIndex("ProductId");

                    b.ToTable("kaziFarmFoods");
                });

            modelBuilder.Entity("StockManagement.Model.KaziFarmFoodMaster_tbl", b =>
                {
                    b.Property<int>("KaziFarmFoodMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KaziFarmFoodMasterId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GrandTotal")
                        .HasColumnType("int");

                    b.Property<decimal?>("GrandTotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalDumping")
                        .HasColumnType("int");

                    b.Property<int?>("TotalEja")
                        .HasColumnType("int");

                    b.Property<int?>("TotalNewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalReceive")
                        .HasColumnType("int");

                    b.Property<int?>("TotalRemaining")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSalesQuantity")
                        .HasColumnType("int");

                    b.HasKey("KaziFarmFoodMasterId");

                    b.ToTable("kaziFarmFoodMaster_Tbl");
                });

            modelBuilder.Entity("StockManagement.Model.LovelloIceCream", b =>
                {
                    b.Property<int>("LovelloIceCreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LovelloIceCreamId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Dumping")
                        .HasColumnType("int");

                    b.Property<int?>("Eja")
                        .HasColumnType("int");

                    b.Property<int>("LovelloIceCreamMasterId")
                        .HasColumnType("int");

                    b.Property<int?>("NewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Receive")
                        .HasColumnType("int");

                    b.Property<int?>("Remaining")
                        .HasColumnType("int");

                    b.Property<int?>("SalesQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("LovelloIceCreamId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("LovelloIceCreamMasterId");

                    b.HasIndex("ProductId");

                    b.ToTable("lovelloIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.LovelloIceCreamMaster_tbl", b =>
                {
                    b.Property<int>("LovelloIceCreamMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LovelloIceCreamMasterId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GrandTotal")
                        .HasColumnType("int");

                    b.Property<decimal?>("GrandTotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalDumping")
                        .HasColumnType("int");

                    b.Property<int?>("TotalEja")
                        .HasColumnType("int");

                    b.Property<int?>("TotalNewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalReceive")
                        .HasColumnType("int");

                    b.Property<int?>("TotalRemaining")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSalesQuantity")
                        .HasColumnType("int");

                    b.HasKey("LovelloIceCreamMasterId");

                    b.ToTable("lovelloIceCreamMaster_Tbl");
                });

            modelBuilder.Entity("StockManagement.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CompanyId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("StockManagement.Model.RoleAssagin", b =>
                {
                    b.Property<int>("RoleAssaginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleAssaginId"), 1L, 1);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleAssaginId");

                    b.ToTable("RoleAssagin");
                });

            modelBuilder.Entity("StockManagement.Model.RoleMaster", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("RoleMaster");
                });

            modelBuilder.Entity("StockManagement.Model.SavoyIceCream", b =>
                {
                    b.Property<int>("SavoyIceCreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SavoyIceCreamId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Dumping")
                        .HasColumnType("int");

                    b.Property<int?>("Eja")
                        .HasColumnType("int");

                    b.Property<int?>("NewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Receive")
                        .HasColumnType("int");

                    b.Property<int?>("Remaining")
                        .HasColumnType("int");

                    b.Property<int?>("SalesQuantity")
                        .HasColumnType("int");

                    b.Property<int>("SavoyIceCreamMasterId")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SavoyIceCreamId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SavoyIceCreamMasterId");

                    b.ToTable("savoyIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.SavoyIceCreamMaster_tbl", b =>
                {
                    b.Property<int>("SavoyIceCreamMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SavoyIceCreamMasterId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GrandTotal")
                        .HasColumnType("int");

                    b.Property<decimal?>("GrandTotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalDumping")
                        .HasColumnType("int");

                    b.Property<int?>("TotalEja")
                        .HasColumnType("int");

                    b.Property<int?>("TotalNewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalReceive")
                        .HasColumnType("int");

                    b.Property<int?>("TotalRemaining")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSalesQuantity")
                        .HasColumnType("int");

                    b.HasKey("SavoyIceCreamMasterId");

                    b.ToTable("savoyIceCreamMaster_tbl");
                });

            modelBuilder.Entity("StockManagement.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StockManagement.Model.ZaNZeeIceCream", b =>
                {
                    b.Property<int>("ZaNZeeIceCreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZaNZeeIceCreamId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Dumping")
                        .HasColumnType("int");

                    b.Property<int?>("Eja")
                        .HasColumnType("int");

                    b.Property<int?>("NewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Receive")
                        .HasColumnType("int");

                    b.Property<int?>("Remaining")
                        .HasColumnType("int");

                    b.Property<int?>("SalesQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ZaNZeeIceCreamMasterId")
                        .HasColumnType("int");

                    b.Property<int?>("ZaNZeeIceCreamMaster_tblZaNZeeIceCreamMasterId")
                        .HasColumnType("int");

                    b.HasKey("ZaNZeeIceCreamId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ZaNZeeIceCreamMasterId");

                    b.HasIndex("ZaNZeeIceCreamMaster_tblZaNZeeIceCreamMasterId");

                    b.ToTable("zaNZeeIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.ZaNZeeIceCreamMaster_tbl", b =>
                {
                    b.Property<int>("ZaNZeeIceCreamMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZaNZeeIceCreamMasterId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GrandTotal")
                        .HasColumnType("int");

                    b.Property<decimal?>("GrandTotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalDumping")
                        .HasColumnType("int");

                    b.Property<int?>("TotalEja")
                        .HasColumnType("int");

                    b.Property<int?>("TotalNewProduct")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TotalReceive")
                        .HasColumnType("int");

                    b.Property<int?>("TotalRemaining")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSalesQuantity")
                        .HasColumnType("int");

                    b.HasKey("ZaNZeeIceCreamMasterId");

                    b.ToTable("zaNZeeIceCreamMaster_Tbl");
                });

            modelBuilder.Entity("StockManagement.Model.Gari1", b =>
                {
                    b.HasOne("StockManagement.Model.Gari1Master_tbl", "Gari1Master_tbl")
                        .WithMany("Gari1s")
                        .HasForeignKey("Gari1MasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.Product", "Product")
                        .WithMany("Gari1s")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gari1Master_tbl");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StockManagement.Model.Gari2", b =>
                {
                    b.HasOne("StockManagement.Model.Gari2Master_tbl", "Gari2Master_tbl")
                        .WithMany("Gari2s")
                        .HasForeignKey("Gari2MasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.Product", "Product")
                        .WithMany("Gari2s")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gari2Master_tbl");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StockManagement.Model.Gari3", b =>
                {
                    b.HasOne("StockManagement.Model.Gari3Master_tbl", "Gari3Master_tbl")
                        .WithMany("Gari3s")
                        .HasForeignKey("Gari3MasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.Product", "Product")
                        .WithMany("Gari3s")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gari3Master_tbl");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StockManagement.Model.IglooIceCream", b =>
                {
                    b.HasOne("StockManagement.Model.Company", "Company")
                        .WithMany("IglooIceCreams")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.IglooIceCreamMaster_tbl", "IglooIceCreamMaster_tbl")
                        .WithMany("IglooIceCreams")
                        .HasForeignKey("IglooIceCreamMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.Product", "Product")
                        .WithMany("IglooIceCreams")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("IglooIceCreamMaster_tbl");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StockManagement.Model.KaziFarmFood", b =>
                {
                    b.HasOne("StockManagement.Model.Company", "Company")
                        .WithMany("KaziFarmFoods")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.KaziFarmFoodMaster_tbl", "KaziFarmFoodMaster_tbl")
                        .WithMany("KaziFarmFoods")
                        .HasForeignKey("KaziFarmFoodMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.Product", "Product")
                        .WithMany("KaziFarmFoods")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("KaziFarmFoodMaster_tbl");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StockManagement.Model.LovelloIceCream", b =>
                {
                    b.HasOne("StockManagement.Model.Company", "Company")
                        .WithMany("LovelloIceCreams")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.LovelloIceCreamMaster_tbl", "LovelloIceCreamMaster_tbl")
                        .WithMany("LovelloIceCreams")
                        .HasForeignKey("LovelloIceCreamMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.Product", "Product")
                        .WithMany("LovelloIceCreams")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("LovelloIceCreamMaster_tbl");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StockManagement.Model.Product", b =>
                {
                    b.HasOne("StockManagement.Model.Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("StockManagement.Model.SavoyIceCream", b =>
                {
                    b.HasOne("StockManagement.Model.Company", "Company")
                        .WithMany("SavoyIceCreams")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.Product", "Product")
                        .WithMany("SavoyIceCreams")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.SavoyIceCreamMaster_tbl", "SavoyIceCreamMaster_tbl")
                        .WithMany("SavoyIceCreams")
                        .HasForeignKey("SavoyIceCreamMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Product");

                    b.Navigation("SavoyIceCreamMaster_tbl");
                });

            modelBuilder.Entity("StockManagement.Model.ZaNZeeIceCream", b =>
                {
                    b.HasOne("StockManagement.Model.Company", "Company")
                        .WithMany("ZaNZeeIceCreams")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.Product", "Product")
                        .WithMany("ZaNZeeIceCreams")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.SavoyIceCreamMaster_tbl", "SavoyIceCreamMaster_Tbl")
                        .WithMany()
                        .HasForeignKey("ZaNZeeIceCreamMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManagement.Model.ZaNZeeIceCreamMaster_tbl", null)
                        .WithMany("ZaNZeeIceCreams")
                        .HasForeignKey("ZaNZeeIceCreamMaster_tblZaNZeeIceCreamMasterId");

                    b.Navigation("Company");

                    b.Navigation("Product");

                    b.Navigation("SavoyIceCreamMaster_Tbl");
                });

            modelBuilder.Entity("StockManagement.Model.Company", b =>
                {
                    b.Navigation("IglooIceCreams");

                    b.Navigation("KaziFarmFoods");

                    b.Navigation("LovelloIceCreams");

                    b.Navigation("Products");

                    b.Navigation("SavoyIceCreams");

                    b.Navigation("ZaNZeeIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.Gari1Master_tbl", b =>
                {
                    b.Navigation("Gari1s");
                });

            modelBuilder.Entity("StockManagement.Model.Gari2Master_tbl", b =>
                {
                    b.Navigation("Gari2s");
                });

            modelBuilder.Entity("StockManagement.Model.Gari3Master_tbl", b =>
                {
                    b.Navigation("Gari3s");
                });

            modelBuilder.Entity("StockManagement.Model.IglooIceCreamMaster_tbl", b =>
                {
                    b.Navigation("IglooIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.KaziFarmFoodMaster_tbl", b =>
                {
                    b.Navigation("KaziFarmFoods");
                });

            modelBuilder.Entity("StockManagement.Model.LovelloIceCreamMaster_tbl", b =>
                {
                    b.Navigation("LovelloIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.Product", b =>
                {
                    b.Navigation("Gari1s");

                    b.Navigation("Gari2s");

                    b.Navigation("Gari3s");

                    b.Navigation("IglooIceCreams");

                    b.Navigation("KaziFarmFoods");

                    b.Navigation("LovelloIceCreams");

                    b.Navigation("SavoyIceCreams");

                    b.Navigation("ZaNZeeIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.SavoyIceCreamMaster_tbl", b =>
                {
                    b.Navigation("SavoyIceCreams");
                });

            modelBuilder.Entity("StockManagement.Model.ZaNZeeIceCreamMaster_tbl", b =>
                {
                    b.Navigation("ZaNZeeIceCreams");
                });
#pragma warning restore 612, 618
        }
    }
}
