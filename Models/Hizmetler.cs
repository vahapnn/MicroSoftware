﻿using System.ComponentModel.DataAnnotations;

namespace MicroYazilim.Models
{
    public class Hizmetler
    {
        [Key]
        public int id { get; set; }
        public String Baslik { get; set; }
        public String Icerik { get; set; }
        public String Resim { get; set; }
    }
}
