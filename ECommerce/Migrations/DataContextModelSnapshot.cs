﻿// <auto-generated />
using System;
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ChiTietDonHangSanPham", b =>
                {
                    b.Property<int>("SanPhamsMaSP")
                        .HasColumnType("int");

                    b.Property<int>("ChiTietDonHangsMaDH")
                        .HasColumnType("int");

                    b.Property<int>("ChiTietDonHangsMaSP")
                        .HasColumnType("int");

                    b.HasKey("SanPhamsMaSP", "ChiTietDonHangsMaDH", "ChiTietDonHangsMaSP");

                    b.HasIndex("ChiTietDonHangsMaDH", "ChiTietDonHangsMaSP");

                    b.ToTable("ChiTietDonHangSanPham");
                });

            modelBuilder.Entity("ECommerce.Areas.Identity.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ECommerce.Data.ProductToCart", b =>
                {
                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SanPhamMaSP")
                        .HasColumnType("int");

                    b.HasIndex("SanPhamMaSP");

                    b.ToTable("productToCarts");
                });

            modelBuilder.Entity("ECommerce.Models.ChiTietDonHang", b =>
                {
                    b.Property<int>("MaDH")
                        .HasColumnType("int");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongSP")
                        .HasColumnType("int");

                    b.Property<int>("SotienSP")
                        .HasColumnType("int");

                    b.Property<int>("TongTienDH")
                        .HasColumnType("int");

                    b.HasKey("MaDH", "MaSP");

                    b.ToTable("ChiTietDonHangs");
                });

            modelBuilder.Entity("ECommerce.Models.DonHang", b =>
                {
                    b.Property<int>("MaDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChuDH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhuyenMaiMaKM")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaTT")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTaoDH")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TinhTrangDHMaTT")
                        .HasColumnType("int");

                    b.HasKey("MaDH");

                    b.HasIndex("KhuyenMaiMaKM");

                    b.HasIndex("TinhTrangDHMaTT");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("ECommerce.Models.KhachHang", b =>
                {
                    b.Property<int>("MaTK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiemKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.Property<int>("TenKh")
                        .HasColumnType("int");

                    b.HasKey("MaTK");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("ECommerce.Models.KhuyenMai", b =>
                {
                    b.Property<string>("MaKM")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChitietKhuyenMai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DieuKienApDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.HasKey("MaKM");

                    b.ToTable("KhuyenMais");
                });

            modelBuilder.Entity("ECommerce.Models.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoai");

                    b.ToTable("Loais");
                });

            modelBuilder.Entity("ECommerce.Models.NhaCungCap", b =>
                {
                    b.Property<int>("MaNhaCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaSoThue")
                        .HasColumnType("int");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.Property<string>("TenNhaCC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhaCC");

                    b.ToTable("NhaCungCaps");
                });

            modelBuilder.Entity("ECommerce.Models.NhanVien", b =>
                {
                    b.Property<int>("MaTK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayNhanViec")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.Property<int>("TenNV")
                        .HasColumnType("int");

                    b.HasKey("MaTK");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("ECommerce.Models.SanPham", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ChiTietSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaLoai")
                        .HasColumnType("int");

                    b.Property<int>("MaNhaCC")
                        .HasColumnType("int");

                    b.Property<int>("MaTH")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongMuaToiThieu")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaNhaCC");

                    b.HasIndex("MaTH");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("ECommerce.Models.ThuongHieu", b =>
                {
                    b.Property<int>("MaTH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTH")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTH");

                    b.ToTable("ThuongHieus");
                });

            modelBuilder.Entity("ECommerce.Models.TinTuc", b =>
                {
                    b.Property<int>("MaTT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TieuDe")
                        .HasColumnType("int");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTT");

                    b.ToTable("TinTucs");
                });

            modelBuilder.Entity("ECommerce.Models.TinhTrangDH", b =>
                {
                    b.Property<int>("MaTT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TrangThaiDH")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTT");

                    b.ToTable("TinhTrangDH");
                });

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "39324423-eeb6-4012-8f15-49f7a2e2c62d",
                            ConcurrencyStamp = "d3243824-9327-46d5-b0e3-327946261a64",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        },
                        new
                        {
                            Id = "9f920db1-c477-437a-8bfc-652772d764b9",
                            ConcurrencyStamp = "e92b4706-feaa-40a8-bc9f-1ae35c178cc6",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ChiTietDonHangSanPham", b =>
                {
                    b.HasOne("ECommerce.Models.SanPham", null)
                        .WithMany()
                        .HasForeignKey("SanPhamsMaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.Models.ChiTietDonHang", null)
                        .WithMany()
                        .HasForeignKey("ChiTietDonHangsMaDH", "ChiTietDonHangsMaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce.Data.ProductToCart", b =>
                {
                    b.HasOne("ECommerce.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamMaSP");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ECommerce.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("ECommerce.Models.DonHang", "DonHang")
                        .WithMany()
                        .HasForeignKey("MaDH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");
                });

            modelBuilder.Entity("ECommerce.Models.DonHang", b =>
                {
                    b.HasOne("ECommerce.Models.KhuyenMai", null)
                        .WithMany("DonHangs")
                        .HasForeignKey("KhuyenMaiMaKM");

                    b.HasOne("ECommerce.Models.TinhTrangDH", "TinhTrangDH")
                        .WithMany("DonHangs")
                        .HasForeignKey("TinhTrangDHMaTT");

                    b.Navigation("TinhTrangDH");
                });

            modelBuilder.Entity("ECommerce.Models.SanPham", b =>
                {
                    b.HasOne("ECommerce.Models.Loai", "Loai")
                        .WithMany("sanPhams")
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.Models.NhaCungCap", "NhaCungCap")
                        .WithMany("sanPhams")
                        .HasForeignKey("MaNhaCC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.Models.ThuongHieu", "ThuongHieu")
                        .WithMany("sanPhams")
                        .HasForeignKey("MaTH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loai");

                    b.Navigation("NhaCungCap");

                    b.Navigation("ThuongHieu");
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
                    b.HasOne("ECommerce.Areas.Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ECommerce.Areas.Identity.Models.ApplicationUser", null)
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

                    b.HasOne("ECommerce.Areas.Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ECommerce.Areas.Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce.Models.KhuyenMai", b =>
                {
                    b.Navigation("DonHangs");
                });

            modelBuilder.Entity("ECommerce.Models.Loai", b =>
                {
                    b.Navigation("sanPhams");
                });

            modelBuilder.Entity("ECommerce.Models.NhaCungCap", b =>
                {
                    b.Navigation("sanPhams");
                });

            modelBuilder.Entity("ECommerce.Models.ThuongHieu", b =>
                {
                    b.Navigation("sanPhams");
                });

            modelBuilder.Entity("ECommerce.Models.TinhTrangDH", b =>
                {
                    b.Navigation("DonHangs");
                });
#pragma warning restore 612, 618
        }
    }
}
