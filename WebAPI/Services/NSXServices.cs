using DaTa.Model;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class NSXServices : NSXIServices
    {
        private readonly CHGiayDBContext _dbContext;
        public NSXServices()
        {
            _dbContext = new CHGiayDBContext();
        }
        public async Task<NSX> AddNSX(string ten, int trangthai)
        {
            try
            {
                var cl = await _dbContext.NSXs.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (cl != null)
                {
                    return null;
                }
                NSX kc = new NSX()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    Status = 1
                };
                _dbContext.NSXs.Add(kc);
                _dbContext.SaveChanges();
                return kc;
            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<bool> DeleteNSX(Guid id)
        {
            try
            {
                var cl = await _dbContext.NSXs.FirstOrDefaultAsync(nv => nv.Id == id);
                if (cl != null)
                {
                    _dbContext.NSXs.Remove(cl);
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

        public async Task<List<NSX>> GetAllNSX()
        {
            try
            {
                return await _dbContext.NSXs.OrderByDescending(x => x.Status).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<NSX> GetNSXById(Guid id)
        {
            try
            {
                var nv = await _dbContext.NSXs.FirstOrDefaultAsync(nv => nv.Id == id);
                return nv;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<NSX> UpdateNSX(Guid id, string ten, int trangthai)
        {
            try
            {
                var cl = await _dbContext.NSXs.FirstOrDefaultAsync(x => x.Id == id);
                if (cl != null)
                {
                    var existingColor = await _dbContext.NSXs.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    cl.Ten = ten;
                    cl.Status = 1;
                    _dbContext.NSXs.Update(cl);
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
