using DaTa.Model;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class NhanVienService : NhanVienIService
    {
        private readonly CHGiayDBContext dBContext;
        public NhanVienService()
        {
            this.dBContext = new CHGiayDBContext();
        }
        public async Task<NhanVien> Add(string ten, string email, string password, string sdt, string diachi, int trangthai, Guid idvaitro)
        {
            NhanVien nv = new NhanVien()
            {
                ID = Guid.NewGuid(),
                Ten = ten,
                Email = email,
                PassWord = password,
                SDT = sdt,
                DiaChi = diachi,
                TrangThai = trangthai,
                IDVaiTro = idvaitro,
            };
                dBContext.NhanViens.Add(nv);
                dBContext.SaveChanges();
                return nv;

        }

        public bool Delete(Guid id)
        {
            var nv = dBContext.NhanViens.FirstOrDefault(nv => nv.ID == id);
            if (nv != null)
            {
                dBContext.NhanViens.Remove(nv);
                dBContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<NhanVien> GetAll()
        {
            return dBContext.NhanViens.ToList();
        }

        public NhanVien GetById(Guid id)
        {
            var nv = dBContext.NhanViens.FirstOrDefault(nv => nv.ID == id);
            return nv;
        }

        public bool Update(Guid id, string ten, string email, string password, string sdt, string diachi, int trangthai, Guid idvaitro)
        {
            var nv = dBContext.NhanViens.FirstOrDefault(x => x.ID == id);
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
    }
}
