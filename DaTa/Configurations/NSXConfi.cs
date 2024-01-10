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
    internal class NSXConfi : IEntityTypeConfiguration<NSX>
    {
        public void Configure(EntityTypeBuilder<NSX> builder)
        {
            builder.ToTable("NSX");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(x => x.Status).HasColumnType("int").IsRequired();
        }
    }
}