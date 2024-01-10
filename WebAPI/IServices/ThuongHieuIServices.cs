using DaTa.Model;

namespace WebAPI.IServices
{
    public interface ThuongHieuIServices
    {
        Task<ThuongHieu> AddThuongHieu(string ten, int trangthai);
        Task<ThuongHieu> GetThuongHieuById(Guid id);
        Task<bool> DeleteThuongHieu(Guid id);
        Task<ThuongHieu> UpdateThuongHieu(Guid id, string ten, int trangthai);
        Task<List<ThuongHieu>> GetAllThuongHieu();
    }
}
