using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class GioHangCT
    {
        public Guid ID { get; set; }
        public int SoLuong { get; set; }     
        public Guid IDNguoiDung { get; set; }
        public Guid IDSanPhamCT { get; set; }
        public virtual GioHang GioHang { get; set; }
        public virtual SanPhamCT SanPhamCT { get; set; }
    }
}
