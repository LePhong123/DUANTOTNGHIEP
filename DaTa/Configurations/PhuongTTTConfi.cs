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
    internal class PhuongTTTConfi : IEntityTypeConfiguration<PhuongThucTT>
    {
        public void Configure(EntityTypeBuilder<PhuongThucTT> builder)
        {
            builder.ToTable("PhuongThucThanhToan");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)");
            builder.Property(x => x.TrangThai).HasColumnType("int");
        }
    }
}
