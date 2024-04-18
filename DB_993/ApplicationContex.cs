using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_993
{
    internal class ApplicationContex : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Realty> Realtys { get; set; } = null!;
        public DbSet<Recommendations> Recommendations { get; set; } = null!;
        public DbSet<Compilation> Compilations { get; set; } = null!;
        public DbSet<BlackList> BlackLists { get; set; } = null!;
        public DbSet<Favourites> Favourites { get; set; } = null!;

        public void ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ProectDB2.db");
        }
    }
}
