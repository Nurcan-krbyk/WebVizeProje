using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vizeProje.Models
{
    public class kutuphane
    {
        [Required]
        public int kitapNo { get; set; }
        [Required]
        public string kitapAdi { get; set; }
        public string kitapYazari { get; set; }

        public int kitapSayfaSayi { get; set; }
        [Required]
        public string ogrAdi { get; set; }
        [Required]
        public string ogrSoyad { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime alisTarihi { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime teslimTarihi { get; set; }
        public string kitapKonusu { get; set; }






    }
}
