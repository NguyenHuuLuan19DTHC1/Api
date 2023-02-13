using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyAPINetCore6.Data
{
    public class ThongTinCCCNContext:IdentityDbContext<ApplicationUser>
    {
        public ThongTinCCCNContext(DbContextOptions<ThongTinCCCNContext> opt): base(opt) 
        {
            
        }
        public DbSet<ThongTinCCCN>? ThongTinCCCNs { get; set; }
    }
}
