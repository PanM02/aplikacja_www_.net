using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    [Table("Producents")]
    public class Producent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Nazwa { get; set; }
        public String Tel { get; set; }
        public String Email {get; set;}
        public ICollection<Produkt> Produkts { get; set; }

    }
}
