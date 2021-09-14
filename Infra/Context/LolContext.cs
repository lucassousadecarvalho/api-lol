using Lol.Infra.Models;
using Microsoft.EntityFrameworkCore;

namespace Lol.Infra.Context
{
    public class LolContext : DbContext
    {
        public LolContext(DbContextOptions<LolContext> options)
        : base(options){}

        public DbSet<CampeaoModel> Campeoes { get; set; }
    }
}