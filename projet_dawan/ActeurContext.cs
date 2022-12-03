using Microsoft.EntityFrameworkCore;
using projet_dawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dawan
{
    internal class ActeurContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Settings.Default.Connection);
        }

        public DbSet<Acteur> Acteurs { get; set; }
    }
}
