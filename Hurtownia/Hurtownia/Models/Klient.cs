using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hurtownia.Models
{
    [Table("Klients")]
    public class Klient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public String Adres { get; set; }

    }
}
