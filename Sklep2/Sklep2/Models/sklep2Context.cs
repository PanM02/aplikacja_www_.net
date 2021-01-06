using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sklep2.Models
{
    public class sklep2Context: DbContext
    {
        public sklep2Context(DbContextOptions<sklep2Context> options): base(options) { }
        public DbSet<Produkt> Produkts { get; set; }
        public DbSet<Producent> Producents { get; set; }
            

    }
}
