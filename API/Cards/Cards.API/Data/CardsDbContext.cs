using Microsoft.EntityFrameworkCore;
using Cards.API.Models;

namespace Cards.API.Data
{
    public class CardsDbContext : DbContext
    {
        protected CardsDbContext(DbContextOptions options) : base(options)
        {
        }

        // dbset
        public DbSet<Card> Cards { get; set; }

    }
}
