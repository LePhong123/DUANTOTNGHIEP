using DaTa.Model;
using Microsoft.EntityFrameworkCore;
using WebAPI.IServices;

namespace WebAPI.Services
{
    public class ThuongHieuServices : ThuongHieuIServices
    {
        private readonly CHGiayDBContext _dbContext;
        public ThuongHieuServices()
        {
            _dbContext = new CHGiayDBContext();
        }
        public async Task<ThuongHieu> AddThuongHieu(string ten, int trangthai)
        {
            try
            {
                var cl = await _dbContext.ThuongHieus.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                if (cl != null)
                {
                    return null;
                }
                ThuongHieu kc = new ThuongHieu()
                {
                    Id = Guid.NewGuid(),
                    Ten = ten,
                    Status = 1
                };
                _dbContext.ThuongHieus.Add(kc);
                _dbContext.SaveChanges();
                return kc;
            }
            catch (Exception)
            {

                throw;

            }
        }

        public async Task<bool> DeleteThuongHieu(Guid id)
        {
            try
            {
                var cl = await _dbContext.ThuongHieus.FirstOrDefaultAsync(nv => nv.Id == id);
                if (cl != null)
                {
                    _dbContext.ThuongHieus.Remove(cl);
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

        public async Task<List<ThuongHieu>> GetAllThuongHieu()
        {
            try
            {
                return await _dbContext.ThuongHieus.OrderByDescending(x => x.Status).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ThuongHieu> GetThuongHieuById(Guid id)
        {
            try
            {
                var nv = await _dbContext.ThuongHieus.FirstOrDefaultAsync(nv => nv.Id == id);
                return nv;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ThuongHieu> UpdateThuongHieu(Guid id, string ten, int trangthai)
        {
            try
            {
                var cl = await _dbContext.ThuongHieus.FirstOrDefaultAsync(x => x.Id == id);
                if (cl != null)
                {
                    var existingColor = await _dbContext.ThuongHieus.FirstOrDefaultAsync(x => x.Ten.Trim().ToUpper() == ten.Trim().ToUpper());
                    if (existingColor != null)
                    {
                        return null; // Trả về null để báo hiệu tên trùng
                    }
                    cl.Ten = ten;
                    cl.Status = 1;
                    _dbContext.ThuongHieus.Update(cl);
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
