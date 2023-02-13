using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyAPINetCore6.Data;
using MyAPINetCore6.Models;

namespace MyAPINetCore6.Repositories
{
    public class ThongTinCCCNRepository : IThongTinCCCNRepository
    {
        private readonly ThongTinCCCNContext _context;
        private readonly IMapper _mapper;

        public ThongTinCCCNRepository(ThongTinCCCNContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddThongTinCCCNAsync(ThongTinCCCNModel model)
        {
            var newThongTinCCCN = _mapper.Map<ThongTinCCCN>(model);
            _context.ThongTinCCCNs!.Add(newThongTinCCCN);
            await _context.SaveChangesAsync();
            return newThongTinCCCN.Id;
        }

        public async Task DeleteThongTinCCCNAsync(int id)
        {
            var deleteThongTinCCCN = _context.ThongTinCCCNs!.SingleOrDefault(b => b.Id == id);
            if (deleteThongTinCCCN != null)
            {
                _context.ThongTinCCCNs!.Remove(deleteThongTinCCCN);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ThongTinCCCNModel>> GetAllThongTinCCCNAsync()
        {
            var ThongTinCCCNs = await _context.ThongTinCCCNs!.ToListAsync();
            return _mapper.Map<List<ThongTinCCCNModel>>(ThongTinCCCNs);
        }

        public async Task<ThongTinCCCNModel> GetThongTinCCCNAsync(int id)
        {
            var ThongTinCCCN = await _context.ThongTinCCCNs!.FindAsync(id);
            return _mapper.Map<ThongTinCCCNModel>(ThongTinCCCN);
        }

        public async Task UpdateThongTinCCCNAsync(int id, ThongTinCCCNModel model)
        {
            if (id == model.Id)
            {
                var updateBook = _mapper.Map<ThongTinCCCN>(model);
                _context.ThongTinCCCNs!.Update(updateBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
