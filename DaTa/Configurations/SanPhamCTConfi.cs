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
    internal class SanPhamCTConfi : IEntityTypeConfiguration<SanPhamCT>
    {
        public void Configure(EntityTypeBuilder<SanPhamCT> builder)
        {
            builder.ToTable("ChiTietSanPham");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SoLuong).HasColumnType("int");
            builder.Property(x => x.GiaBan).HasColumnType("int");
            builder.Property(x => x.NgayTao).HasColumnType("datetime");
            builder.Property(x => x.TrangThai).HasColumnType("int");
            builder.HasOne(x => x.KichCo).WithMany(x => x.SanPhamCTs).HasForeignKey(x => x.IDKichCo);
            //builder.HasOne(x => x.SanPham).WithMany(x => x.SanPhamCTs).HasForeignKey(x => x.IDSanPham);
            builder.HasOne(x => x.LoaiSanPham).WithMany(x => x.SanPhamCTs).HasForeignKey(x => x.IDLoaiSP);
            builder.HasOne(x => x.ChatLieu).WithMany(x => x.SanPhamCTs).HasForeignKey(x => x.IDChatLieu);
            builder.HasOne(x => x.NSX).WithMany(x => x.SanPhamCTs).HasForeignKey(x => x.IDNSX);
            builder.HasOne(x => x.ThuongHieu).WithMany(x => x.SanPhamCTs).HasForeignKey(x => x.IDThuongHieu);
            builder.HasOne(x => x.KhuyenMai).WithMany(x => x.SanPhamCTs).HasForeignKey(x => x.IDKhuyenMai);
        }
    }
}
