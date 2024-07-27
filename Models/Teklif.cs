using System.ComponentModel.DataAnnotations;

namespace MicroYazilim.Models
{
    public class Teklif
    {
        [Key]
        public int id { get; set; }
        public String AdSoyad { get; set; }
        public String  FirmaIsmi { get; set; }
        public String Email { get; set; }
        public int Telefon { get; set; }
        public String HizmetTuru { get; set; }
    }
}
