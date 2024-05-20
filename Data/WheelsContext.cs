using Microsoft.EntityFrameworkCore;
using WheelsBlazor.Data.Entities;

namespace WheelsBlazor.Data
{
    public class WheelsContext : DbContext
    {
        public WheelsContext(DbContextOptions<WheelsContext> options) : base(options) { }

        public DbSet<WheelsTable> WheelsTable { get; set; }
        public DbSet<Alutec> Alutec { get; set; }
        public DbSet<Anzio> Anzio { get; set; }
        public DbSet<Ats> Ats { get; set; }
        public DbSet<Rial> Rial { get; set; }
        public DbSet<FetchedData> FetchedDatas { get; set; }
    }
}