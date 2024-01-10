using DaTa.Model;

namespace WebAPI.IServices
{
    public interface KichCoIServices
    {
        Task<KichCo> AddKichCo(string ten, int trangthai);
        Task<KichCo> GetKickCoById(Guid id);
        Task<bool> DeleteKichCo(Guid id);
        Task<KichCo> UpdateKichCo(Guid id, string ten, int trangthai);
        Task<List<KichCo>> GetAllKichCo();
    }
}
