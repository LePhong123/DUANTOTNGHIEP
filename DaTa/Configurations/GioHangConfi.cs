using DaTa.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Configurations
{
    internal class GioHangConfi : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(x => x.IDKhachHang);
            builder.Property(x => x.NgayTao).HasColumnType("datetime");
            builder.HasOne(x => x.KhachHang).WithOne(x => x.GioHang).HasForeignKey<KhachHang>();
        }
    }
}
