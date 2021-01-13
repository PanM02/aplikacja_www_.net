using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    [Table("Zamowienias")]
    public class Zamowienia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Id_klienta { get; set; }
        public Klient Klient { get; set; }
        public int Id_Producenta { get; set; }
        public Produkt Produkt { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
    }
}
