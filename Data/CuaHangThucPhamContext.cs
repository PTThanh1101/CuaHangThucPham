using Microsoft.EntityFrameworkCore;

namespace CuaHangThucPham.Data
{
    public class CuaHangThucPhamContext : DbContext
    {
        public CuaHangThucPhamContext(DbContextOptions<CuaHangThucPhamContext> options)
            : base(options)
        {
        }

        public DbSet<CuaHangThucPham.Models.Product> Product { get; set; } = default!;
    }
}
