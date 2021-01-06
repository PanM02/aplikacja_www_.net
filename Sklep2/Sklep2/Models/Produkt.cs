using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Sklep2.Models
{   
    [Table("Produkts")]
    public class Produkt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nazwa { get; set; }
         public int Ilosc { get; set; }
        public int Id_producenta { get; set; }
        public  Group Group{ get; set; }
       


    }
}
