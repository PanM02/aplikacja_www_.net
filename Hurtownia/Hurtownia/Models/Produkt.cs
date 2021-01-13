using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    [Table("Produkts")]
    public class Produkt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Id_producent { get; set; }
        public String Nazwa { get; set; }
        public int Ilosc { get; set; }
        public int Id_producenta { get; set; }
        public Producent Producent { get; set; }
    }
}
