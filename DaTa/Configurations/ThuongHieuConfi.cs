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
    internal class ThuongHieuConfi : IEntityTypeConfiguration<ThuongHieu>
    {
        public void Configure(EntityTypeBuilder<ThuongHieu> builder)
        {
            builder.ToTable("ThuongHieu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Status).HasColumnType("int").IsRequired();
        }
    }
}