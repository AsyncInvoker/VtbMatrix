using Microsoft.EntityFrameworkCore;

namespace VtbMatrix.Models
{
    /// <summary>
    /// DbContext для БД VtbMatrix.
    /// </summary>
    public class VtbMatrixDbContext : DbContext
    {
        public VtbMatrixDbContext(DbContextOptions<VtbMatrixDbContext> options)
            :base(options)
        {

        }

        public DbSet<HistoryLine> HistoryLines { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }
        public DbSet<NftCertificate> NftCertificates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
