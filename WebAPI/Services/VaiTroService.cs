using DaTa.Model;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class VaiTroService : VaiTroIService
    {
        private readonly CHGiayDBContext dBContext;

        public VaiTroService()
        {
            this.dBContext = new CHGiayDBContext();
        }
        public bool CreateVaiTro(string ten, int trangthai)
        {
            var vaitro = new VaiTro();
            vaitro.Id = Guid.NewGuid();
            vaitro.Ten = ten;
            vaitro.TrangThai = trangthai;
            dBContext.VaiTros.Add(vaitro);
            dBContext.SaveChanges();
            return true;
        }

        public bool DeleteVaiTro(Guid id)
        {
            try
            {
                var vt = dBContext.VaiTros.FirstOrDefault(a => a.Id == id);
                if (vt != null)
                {
                    dBContext.VaiTros.Remove(vt);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<VaiTro> GetAllVaiTro()
        {
            return dBContext.VaiTros.ToList();
        }

        public VaiTro GetVaiTroById(Guid id)
        {
            return dBContext.VaiTros.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateVaiTro(Guid id, string ten, int trangthai)
        {
            var vaitro = dBContext.VaiTros.FirstOrDefault(a => a.Id == id);
            if (vaitro == null)
            {
                return false;
            }
            else
            {
                vaitro.Ten = ten;
                vaitro.TrangThai = trangthai;
                dBContext.VaiTros.Update(vaitro);
                dBContext.SaveChanges();
                return true;
            }
        }
    }
}
