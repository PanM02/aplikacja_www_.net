using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hurtownia.Models
{
    public class HurtowniaContext : DbContext
    {
        public HurtowniaContext(DbContextOptions<HurtowniaContext> options) : base(options) { }
        public DbSet<Zamowienia> Zamowienias { get; set; }
        public DbSet<Klient> Klients { get; set; }
        public DbSet<Produkt> Produkts { get; set; }
        public DbSet<Producent> Producents { get; set; }


    }
}
