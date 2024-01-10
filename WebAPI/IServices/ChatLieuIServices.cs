using DaTa.Model;

namespace WebAPI.IServices
{
    public interface ChatLieuIServices
    {
        Task<ChatLieu> AddChatLieu(string ten, int trangthai);
        Task<ChatLieu> GetChatLieuById(Guid id);
        Task<bool> DeleteChatLieu(Guid id);
        Task<ChatLieu> UpdateChatLieu(Guid id, string ten, int trangthai);
        Task<List<ChatLieu>> GetAllChatLieu();
    }
}
