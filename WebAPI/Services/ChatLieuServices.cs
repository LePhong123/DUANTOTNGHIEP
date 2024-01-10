using DaTa.Model;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class ChatLieuServices : ChatLieuIServices
    {
        private readonly CHGiayDBContext _dbContext;
        public ChatLieuServices()
        {
            _dbContext = new CHGiayDBContext();
        }
        public async Task<ChatLieu> AddChatLieu(string ten, int trangthai)
        {
            try
            {
                var cl = await _dbContext.ChatLieus.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (cl != null)
                {
                    return null;
                }
                ChatLieu kc = new ChatLieu()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    Status = 1
                };
                _dbContext.ChatLieus.Add(kc);
                _dbContext.SaveChanges();
                return kc;

            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<bool> DeleteChatLieu(Guid id)
        {
            try
            {
                var cl = await _dbContext.ChatLieus.FirstOrDefaultAsync(nv => nv.Id == id);
                if (cl != null)
                {
                    _dbContext.ChatLieus.Remove(cl);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ChatLieu>> GetAllChatLieu()
        {
            try
            {
                return await _dbContext.ChatLieus.OrderByDescending(x => x.Status).ToListAsync();
            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<ChatLieu> GetChatLieuById(Guid id)
        {
            try
            {
                var cl = await _dbContext.ChatLieus.FirstOrDefaultAsync(cl => cl.Id == id);
                return cl;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ChatLieu> UpdateChatLieu(Guid id, string ten, int trangthai)
        {
            try
            {
                var cl = await _dbContext.ChatLieus.FirstOrDefaultAsync(x => x.Id == id);
                if (cl != null)
                {
                    var existingColor = await _dbContext.ChatLieus.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    cl.Ten = ten;
                    cl.Status = 1;
                    _dbContext.ChatLieus.Update(cl);
                    _dbContext.SaveChanges();
                    return cl;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
