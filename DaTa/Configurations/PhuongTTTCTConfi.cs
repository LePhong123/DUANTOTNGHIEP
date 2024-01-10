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
    internal class PhuongTTTCTConfi : IEntityTypeConfiguration<PhuongThucTTCT>
    {
        public void Configure(EntityTypeBuilder<PhuongThucTTCT> builder)
        {
            builder.ToTable("ChiTietPTTT");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SoTien).HasColumnType("int");
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.HoaDon).WithMany(x => x.PhuongThucTTCTs).HasForeignKey(x => x.IDHoaDon);
            builder.HasOne(x => x.PhuongThucTT).WithMany(x => x.PhuongThucTTCTs).HasForeignKey(x => x.IDPTTT);
        }
    }
}
