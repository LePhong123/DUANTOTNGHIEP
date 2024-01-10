using DaTa.Model;

namespace WebAPI.IServices
{
    public interface NSXIServices
    {
        Task<NSX> AddNSX(string ten, int trangthai);
        Task<NSX> GetNSXById(Guid id);
        Task<bool> DeleteNSX(Guid id);
        Task<NSX> UpdateNSX(Guid id, string ten, int trangthai);
        Task<List<NSX>> GetAllNSX();
    }
}
