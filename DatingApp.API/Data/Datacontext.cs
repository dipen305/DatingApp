
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions options) : base(options) {}
            public DbSet<Value> Values { get; set; }
    }
}