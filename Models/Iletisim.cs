using System.ComponentModel.DataAnnotations;

namespace MicroYazilim.Models
{
    public class Iletisim
    {
        [Key]
        public int id { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Konu { get; set; }
        public String Mesaj { get; set; }
    }
}