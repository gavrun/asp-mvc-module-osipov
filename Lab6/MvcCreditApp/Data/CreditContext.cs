using Microsoft.EntityFrameworkCore;

namespace MvcCreditApp.Data
{
    public class CreditContext : DbContext
    {
        public CreditContext(DbContextOptions<CreditContext> options) : base(options)
        {
        }
        public DbSet<MvcCreditApp.Models.Credit> Credits { get; set; }
        public DbSet<MvcCreditApp.Models.Bid> Bids { get; set; }
    }
}
