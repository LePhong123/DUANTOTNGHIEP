﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.Model
{
    public class Anh
    {
        public Guid ID { get; set; }
        public string AnhSP { get; set; }
        public int TrangThai { get; set; }
        public Guid IDSanPhamCT { get; set; }
        public virtual SanPhamCT SanPhamCT { get; set; }
    }
}
