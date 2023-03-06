using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lab02.Models
{
    internal class JournalContext:DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Auther> Authers { get; set; }
        public virtual DbSet<NewsDetail> NewsDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-A89CRET;Database=Journal;Trusted_Connection=True; TrustServerCertificate=True");

        }

    }
}
