using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class KhachHang
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public string Password { get; set; }
        public int? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public int? DiemTich { get; set; }
        public int? TrangThai { get; set; }
        public virtual GioHang? GioHang { get; set; }
        public virtual IEnumerable<HoaDon>? HoaDons { get; set; }
    }
}
