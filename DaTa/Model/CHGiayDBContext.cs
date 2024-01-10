using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class CHGiayDBContext : DbContext
    {
        public CHGiayDBContext()
        {
        }
        public CHGiayDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<GioHangCT> GioHangCTs { get; set; }
        public DbSet<SanPhamCT> SanPhamCTs { get; set; }
        public DbSet<KichCo> KichCos { get; set; }
        public DbSet<ChatLieu> ChatLieus { get; set; }
        public DbSet<HoaDonCT> HoaDonCTs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        //public DbSet<DanhGia> DanhGias { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Anh> Anhs { get; set; }
        public DbSet<PhuongThucTTCT> PhuongThucTTCTs { get; set; }
        public DbSet<PhuongThucTT> PhuongThucTTs { get; set; }
        public DbSet<NSX> NSXs { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-UBD0I1G\SQLEXPRESS;Initial Catalog=BaoVe_DuAn;User ID=phonglhph24259;Password=123");

           
        }
        //THUYNHU\SQLEXPRESS
        //DESKTOP-UOIH77U\SQLEXPRESS
        //LAPTOP-A15NGLBG\SQLEXPRESS
        // lam DESKTOP-S6G7NFV\SQLEXPRESS
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
