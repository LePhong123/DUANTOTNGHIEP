using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class HoaDonCT
    {
        public Guid ID { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public Guid IDSanPHamCT { get; set; }
        public Guid IDHoaDon { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
        public virtual SanPhamCT? SanPhamCT { get; set; }
        
    }
}
