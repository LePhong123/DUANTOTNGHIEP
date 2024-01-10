using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaTa.Model;

namespace DaTa.Configurations
{
    internal class HoaDonConfi : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.NgayTao).HasColumnType("datetime");
            builder.Property(x => x.NgayThanhToan).HasColumnType("datetime");
            builder.Property(x => x.TenNguoiNhan).HasColumnType("nvarchar(100)");
            builder.Property(x => x.SDT).HasColumnType("nvarchar(10)");
            builder.Property(x => x.Email).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(x => x.TienShip).HasColumnType("int");
            builder.Property(x => x.PhuongThucThanhToan).HasColumnType("nvarchar(20)");
            builder.Property(x => x.Status).HasColumnType("int");
            builder.HasOne(x => x.NhanVien).WithMany(x => x.HoaDons).HasForeignKey(x => x.IDNhanVien);
            builder.HasOne(x => x.KhachHang).WithMany(x => x.HoaDons).HasForeignKey(x => x.IDKhacHang);
            builder.HasOne(x => x.Voucher).WithMany(x => x.HoaDons).HasForeignKey(x => x.IDVoucher);
        }
    }
}


