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
    internal class HoaDonCTConfi : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.ToTable("ChiTietHoaDon");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.DonGia).HasColumnType("int");
            builder.Property(x => x.SoLuong).HasColumnType("int");
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.HoaDon).WithMany(x => x.HoaDonCTs).HasForeignKey(x => x.IDHoaDon);
            builder.HasOne(x => x.SanPhamCT).WithMany(x => x.HoaDonCTs).HasForeignKey(x => x.IDSanPHamCT);
        }
    }
}
