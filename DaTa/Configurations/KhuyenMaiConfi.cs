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
    internal class KhuyenMaiConfi : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.ToTable("KhuyenMai");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)");
            builder.Property(x => x.GiaTri).HasColumnType("int");
            builder.Property(x => x.NgayApDung).HasColumnType("datetime");
            builder.Property(x => x.NgayKetThuc).HasColumnType("datetime");
            builder.Property(x => x.MoTa).HasColumnType("nvarchar(1000)");
            builder.Property(x => x.Status).HasColumnType("int");
        }
    }
}