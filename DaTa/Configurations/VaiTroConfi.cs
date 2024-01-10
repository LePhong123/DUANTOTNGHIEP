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
    internal class VaiTroConfi : IEntityTypeConfiguration<VaiTro>
    {
        public void Configure(EntityTypeBuilder<VaiTro> builder)
        {
            builder.ToTable("VaiTro");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int");
        }
    }
}
