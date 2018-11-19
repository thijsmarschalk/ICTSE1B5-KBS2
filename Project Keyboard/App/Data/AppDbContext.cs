using App.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Gebruiker> Gebruikers { get; set; }
    }
}
