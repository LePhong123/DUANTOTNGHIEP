using DaTa.Model;

namespace WebAPI.IServices
{
    public interface VaiTroIService
    {
        public List<VaiTro> GetAllVaiTro();
        public VaiTro GetVaiTroById(Guid id);
        public bool CreateVaiTro(string ten, int trangthai);
        public bool DeleteVaiTro(Guid id);
        public bool UpdateVaiTro(Guid id, string ten, int trangthai);
    }
}
