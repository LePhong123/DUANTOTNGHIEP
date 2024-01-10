using DaTa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly NhanVienIService _nhanVienService;
        private readonly CHGiayDBContext dBContext;
        public NhanVienController()
        {
            this._nhanVienService = new NhanVienService();
            this.dBContext = new CHGiayDBContext();
        }
        // GET: api/<NhanVienController>
        [HttpGet("GetAll")]
        public List<NhanVien> GetAllNhanVien()
        {
            return _nhanVienService.GetAll();
        }
        [Route("TimKiemNhanVien")]
        [HttpGet]
        public List<NhanVien> GetAllNhanVien(string? name)
        {
            return dBContext.NhanViens.Where(v => v.Ten.Contains(name)).ToList();


        }

        // GET api/<NhanVienController>/5
        [Route("GetById")]
        [HttpGet]
        public NhanVien? GetById(Guid id)
        {
            return _nhanVienService.GetById(id);
        }


        // POST api/<NhanVienController>
        [HttpPost("DangKyNhanVien")]
        public bool Add(string ten, string email, string password, string sdt, string diachi, int trangthai, Guid idvaitro)
        {
            NhanVien nv = new NhanVien();
            nv.ID = Guid.NewGuid();
            nv.Ten = ten;
            nv.Email = email;
            nv.PassWord = password;
            nv.SDT = sdt;
            nv.DiaChi = diachi;
            nv.TrangThai = trangthai;
            nv.IDVaiTro = idvaitro;
            dBContext.NhanViens.Add(nv);
            dBContext.SaveChanges();
            return true;
        }

        // PUT api/<NhanVienController>/5
        [HttpPut("{id}")]
        public bool Put(Guid id, string ten, string email, string password, string sdt, string diachi, int trangthai, Guid idvaitro)
        {
            var nv = _nhanVienService.GetById(id);
            if (nv != null)
            {
                nv.Ten = ten;
                nv.Email = email;
                nv.PassWord = password;
                nv.SDT = sdt;
                nv.DiaChi = diachi;
                nv.TrangThai = trangthai;
                nv.IDVaiTro = idvaitro;
                dBContext.NhanViens.Update(nv);
                dBContext.SaveChanges();
                return true;
            }
            return false;

        }

        // DELETE api/<NhanVienController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            if (_nhanVienService.Delete(id))
            {
                return true;
            }
            return false;
        }
    }
}
