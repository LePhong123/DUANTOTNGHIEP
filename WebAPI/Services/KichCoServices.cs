using DaTa.Model;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class KichCoServices : KichCoIServices
    {
        private readonly CHGiayDBContext _dbContext;
        public KichCoServices()
        {
            _dbContext = new CHGiayDBContext();  
        }
        public async Task<KichCo> AddKichCo(string ten, int trangthai)
        {
            try
            {
                var cl = await _dbContext.KichCos.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (cl != null)
                {
                    return null;
                }
                KichCo kc = new KichCo()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    TrangThai = 1
                };
                _dbContext.KichCos.Add(kc);
                _dbContext.SaveChanges();
                return kc;
            }
            catch (Exception)
            {

                throw;

            }
        }
        public async Task<bool> DeleteKichCo(Guid id)
        {
            try
            {
                var cl = await _dbContext.KichCos.FirstOrDefaultAsync(nv => nv.Id == id);
                if (cl != null)
                {
                    _dbContext.KichCos.Remove(cl);
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

        public async Task<List<KichCo>> GetAllKichCo()
        {
            try
            {
                return await _dbContext.KichCos.OrderByDescending(x => x.TrangThai).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<KichCo> GetKickCoById(Guid id)
        {
            try
            {
                var nv = await _dbContext.KichCos.FirstOrDefaultAsync(nv => nv.Id == id);
                return nv;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<KichCo> UpdateKichCo(Guid id, string ten, int trangthai)
        {
            try
            {
                var cl = await _dbContext.KichCos.FirstOrDefaultAsync(x => x.Id == id);
                if (cl != null)
                {
                    var existingColor = await _dbContext.KichCos.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    cl.Ten = ten;
                    cl.TrangThai = 1;
                    _dbContext.KichCos.Update(cl);
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
