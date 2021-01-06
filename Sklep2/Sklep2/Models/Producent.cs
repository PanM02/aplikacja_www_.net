using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Sklep2.Models
{
    [Table("Producents")]
    public class Producent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public int Tel { get; set; }
        public ICollection<Produkt> Produkts { get; set; }
    }
}
