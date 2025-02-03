using Microsoft.EntityFrameworkCore;
using PSGC.Api.Entities;

namespace PSGC.Api.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public virtual DbSet<GeoData> GeoDatas { get; set; }
        public virtual DbSet<Location> psgc { get; set; }
    }
}
