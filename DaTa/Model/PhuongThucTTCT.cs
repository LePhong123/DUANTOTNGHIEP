using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class PhuongThucTTCT
    {
        public Guid ID { get; set; }
        public int SoTien { get; set; }
        public int TrangThai { get; set; }
        public Guid IDPTTT { get; set; }
        public Guid IDHoaDon { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual PhuongThucTT PhuongThucTT { get; set; }
    }
}
