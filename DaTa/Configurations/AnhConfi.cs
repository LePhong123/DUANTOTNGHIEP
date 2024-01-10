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
    internal class AnhConfi : IEntityTypeConfiguration<Anh>
    {
        public void Configure(EntityTypeBuilder<Anh> builder)
        {
            builder.ToTable("Anh");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.AnhSP).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.SanPhamCT).WithMany(x => x.Anhs).HasForeignKey(x => x.IDSanPhamCT);
        }
    }
}
