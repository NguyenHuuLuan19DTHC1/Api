using MyAPINetCore6.Data;
using MyAPINetCore6.Models;

namespace MyAPINetCore6.Repositories
{
    public interface IThongTinCCCNRepository
    {
        public Task<List<ThongTinCCCNModel>> GetAllThongTinCCCNAsync();
        public Task<ThongTinCCCNModel> GetThongTinCCCNAsync(int id);
        public Task<int> AddThongTinCCCNAsync(ThongTinCCCNModel model);
        public Task UpdateThongTinCCCNAsync(int id, ThongTinCCCNModel model);
        public Task DeleteThongTinCCCNAsync(int id);
    }
}
