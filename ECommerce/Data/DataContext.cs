using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ECommerce.Areas.Identity.Models;

namespace ECommerce.Data
{
    public class DataContext:IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "Visitor",
                NormalizedName = "VISITOR"
            },
            new IdentityRole
            {
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            });
            builder.Entity<ChiTietDonHang>().HasKey(pk => new { pk.MaDH, pk.MaSP });
            builder.Entity<ProductToCart>().HasNoKey();
        }
        public DbSet<ProductToCart> productToCarts { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs{ get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }
        public DbSet<ECommerce.Models.TinhTrangDH> TinhTrangDH { get; set; }
    }
}
