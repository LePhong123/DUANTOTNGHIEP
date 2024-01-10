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
    internal class LoaiSPConfi : IEntityTypeConfiguration<LoaiSanPham>
    {
        public void Configure(EntityTypeBuilder<LoaiSanPham> builder)
        {
            builder.ToTable("LoaiSP");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Status).HasColumnType("int");
            //builder.HasOne(x => x.LoaiSPCha).WithMany().HasForeignKey(x => x.IDLoaiSPCha);
        }
    }
}