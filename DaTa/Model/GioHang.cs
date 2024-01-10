using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class GioHang
    {
        public Guid IDKhachHang { get; set; }
        public DateTime NgayTao { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual IEnumerable<GioHangCT> GioHangCTs { get; set; }
    }
}
