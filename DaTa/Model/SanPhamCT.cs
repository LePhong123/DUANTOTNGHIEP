using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class SanPhamCT
    {
        public Guid ID { get; set; }
        public int Ma { get; set; }
        public int SoLuong { get; set; }
        public int GiaBan { get; set; }
        public DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }
        public Guid IDKhuyenMai { get; set; }
        public Guid IDKichCo { get; set; }
        public Guid IDChatLieu { get; set; }
        public Guid IDNSX { get; set; }
        public Guid IDThuongHieu { get; set; }
        public Guid IDLoaiSP { get; set; }

        public virtual KichCo KichCo { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual ChatLieu ChatLieu { get; set; }
        public virtual NSX NSX { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual IEnumerable<Anh> Anhs { get; set; }
        public virtual IEnumerable<HoaDonCT> HoaDonCTs { get; set; }
        public virtual IEnumerable<GioHangCT> GioHangCTs { get; set; }

    }
}
