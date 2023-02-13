using AutoMapper;
using MyAPINetCore6.Data;
using MyAPINetCore6.Models;

namespace MyAPINetCore6.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<ThongTinCCCN, ThongTinCCCNModel>().ReverseMap();
        }
    }
}
