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
    internal class GioHangCTConfi : IEntityTypeConfiguration<GioHangCT>
    {
        public void Configure(EntityTypeBuilder<GioHangCT> builder)
        {
            builder.ToTable("ChiTietGioHang");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SoLuong).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.SanPhamCT).WithMany(x => x.GioHangCTs).HasForeignKey(x => x.IDSanPhamCT);
            builder.HasOne(x => x.GioHang).WithMany(x => x.GioHangCTs).HasForeignKey(x => x.IDNguoiDung);
        }
    }
}
