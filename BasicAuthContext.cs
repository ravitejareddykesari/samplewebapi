using Microsoft.EntityFrameworkCore;
using samplewebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace samplewebapi
{
    public class BasicAuthContext : DbContext
    {
        public BasicAuthContext()
        {

        }
        public BasicAuthContext(DbContextOptions<BasicAuthContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = MC1JUNB2134; Persist Security Info=True;User ID=sa;Password=pass@word1;Initial Catalog = Company");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<UserAccount> Personsample { get; set; }
    }
}
