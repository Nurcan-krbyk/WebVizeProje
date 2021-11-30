using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vizeProje.Models
{
    public class kutuphaneVeri
    {
        public static List<kutuphane> kütüphane1 = new List<kutuphane>()
        {
            new kutuphane()
            {
                kitapNo=1,
                kitapAdi="Tutunamayanlar",
                kitapYazari="Oğuz ATAY",
                kitapSayfaSayi=724,
                ogrAdi="Derya",
                ogrSoyad="TÜRK",
                alisTarihi= DateTime.Now,
                teslimTarihi = DateTime.Now,
                kitapKonusu="Tutunamayanlar konusu itibariyle intihar eden arkadaşının geçmişini araştıran Turgut Özben'in, söz konusu arkadaşı Selim Işık'ın modern hayata neden “Tutunamadığı”nı öğrenme çabasını anlatmaktadır."


            },
            new kutuphane()
            {
                kitapNo=2,
                kitapAdi="Aşk-ı Memnu",
                kitapYazari="Halid Ziya Uşaklıgil",
                kitapSayfaSayi=520,
                ogrAdi="Ahmet",
                ogrSoyad="ÖZGÜR",
                alisTarihi= DateTime.Now,
                teslimTarihi = DateTime.Now,
                kitapKonusu="Romanda, aşktan başka dertleri olmayan, varlıklı, hazır yiyici, Batılı yaşama biçimine düşkün insanların yasak aşk serüvenleri anlatılır. Melih Bey, serbest yaşamayı, eğlenmeyi çok seven Firdevs Hanım'la evlidir. ... Romanda bu ailenin yolları, Adnan Bey ailesiyle kesişir."
            },
            new kutuphane()
            {
                kitapNo=3,
                kitapAdi="Fatih-Harbiye",
                kitapYazari="Peyami Safa",
                kitapSayfaSayi=128,
                ogrAdi="Melisa",
                ogrSoyad="KALAYCI",
                alisTarihi= DateTime.Now,
                teslimTarihi = DateTime.Now,
                kitapKonusu="Tramvay yoluyla birbirine bağlanan ama birbirinden tamamen kopuk iki semt: Fatih ve Harbiye. Bir genç kızın bu iki semt arasındaki gelgitleri, doğu ve batı kültürleri arasında bocalayan bir Türk gencinin yaşadığı kimlik problemleriyle, dönemin sosyal yapısına ışık tutan, hüzünlü bir hikâye: Fatih-Harbiye."
            },
            new kutuphane()
            {
                kitapNo=4,
                kitapAdi="Araba Sevdası",
                kitapYazari="Recâizâde Mahmut Ekrem",
                kitapSayfaSayi=224,
                ogrAdi="Nurcan",
                ogrSoyad="KARABIYIK",
                alisTarihi= DateTime.Now,
                teslimTarihi = DateTime.Now,
                kitapKonusu="Recaizade Mahmut Ekrem'in 1898'de yayımlanan Araba Sevdası adlı eseri, yazıldığı dönemin burjuva gençliğini anlatır. Türk edebiyatında ilk realist roman örneği olarak bilinen romanın başkahramanı Bihruz Bey, tam bir Fransız kültürü hayranıdır. Şık giyinir, lüksü sever, hatta mirasyedidir."
            }
        };

    }
}
