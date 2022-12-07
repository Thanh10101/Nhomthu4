using Microsoft.EntityFrameworkCore;

namespace giữa_kỳ.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<CauThu> CauThu { get; set; }
        public DbSet<ChiTietCauThuGhiBan> ChiTietCauThuGhiBan { get; set; }
        public DbSet<ChiTietDoiKhach> chiTietDoiKhach { get; set; }
        public DbSet<ChiTietDoiNha> chiTietDoiNha { get; set; }
        public DbSet<DoiBong> doiBong { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=.;Database=EFCoreCodeFirst-
QLBH;Integrated Security=True;");

        }
    }
}
