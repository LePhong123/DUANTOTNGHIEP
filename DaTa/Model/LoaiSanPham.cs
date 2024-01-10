using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class LoaiSanPham
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public int Status { get; set; }   
        public virtual IEnumerable<SanPhamCT> SanPhamCTs { get; set; }
    }
}
