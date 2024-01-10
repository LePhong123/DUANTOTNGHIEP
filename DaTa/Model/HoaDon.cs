using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class HoaDon
    {
        public Guid ID { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string? TenNguoiNhan { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public int TienShip { get; set; }
        public string? PhuongThucThanhToan { get; set; }
        public int TrangThai{ get; set; }
        public Guid? IDNhanVien { get; set; }
        public Guid? IDKhacHang { get; set; }
        public Guid? IDVoucher { get; set; }
        public int? ThueVAT { get; set; }
        public int? TongTien { get; set; }
        public int Status { get; set; }
        public int LoaiHD { get; set; } // Hóa đơn Online-0, Tại quầy-1
        public virtual NhanVien? NhanVien { get; set; }
        public virtual Voucher? Voucher { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual IEnumerable<HoaDonCT>? HoaDonCTs { get; set; }
        public virtual IEnumerable<PhuongThucTTCT>? PhuongThucTTCTs { get; set; }
    }
}
