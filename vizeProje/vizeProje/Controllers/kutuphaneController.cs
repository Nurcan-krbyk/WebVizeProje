using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vizeProje.Controllers
{
    public class kutuphaneController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult listele()
        {
            return View(Models.kutuphaneVeri.kütüphane1);
        }
        public IActionResult yeni()
        {
            return View();
        }
        [HttpPost]
        public IActionResult yeni(Models.kutuphane yeniVeri)
        {
            Models.kutuphaneVeri.kütüphane1.Add(yeniVeri);//şuan yeni kayıt oluşturmaya çalışoılıyor
          
            return RedirectToAction("listele");//listele sayfasına dön
        }
        public IActionResult guncelle(int kitapNo)
        {
            var r = Models.kutuphaneVeri.kütüphane1.FirstOrDefault(x => x.kitapNo == kitapNo);//guncelleme işlemi
            return View(r);
        }
        [HttpPost]
        public IActionResult guncelle(Models.kutuphane yeniVeriGun)
        {
            var c = Models.kutuphaneVeri.kütüphane1.FirstOrDefault(x => x.kitapNo == yeniVeriGun.kitapNo);//şuan yeni kayıt oluşturmaya çalışoılıyor

            var r = Models.kutuphaneVeri.kütüphane1.FirstOrDefault(x => x.kitapNo == yeniVeriGun.kitapNo);//şuan yeni kayıt oluşturmaya çalışoılıyor
            r.kitapAdi = yeniVeriGun.kitapAdi;
            r.kitapYazari = yeniVeriGun.kitapYazari;
            r.kitapSayfaSayi = yeniVeriGun.kitapSayfaSayi;
            r.ogrAdi = yeniVeriGun.ogrAdi;
            r.ogrSoyad = yeniVeriGun.ogrSoyad;
            r.alisTarihi = yeniVeriGun.alisTarihi;
            r.teslimTarihi = yeniVeriGun.teslimTarihi;
            Models.kutuphaneVeri.kütüphane1.Remove(c);
            Models.kutuphaneVeri.kütüphane1.Add(r);

            return RedirectToAction("listele");//listele sayfasına dön
        }
        public IActionResult detay(int kitapNo)
        {
            var r = Models.kutuphaneVeri.kütüphane1.FirstOrDefault(x => x.kitapNo == kitapNo);
            return View(r);
        }
        public IActionResult sil(int kitapNo)
        {
            var r = Models.kutuphaneVeri.kütüphane1.FirstOrDefault(x => x.kitapNo == kitapNo);
            return View(r);
        }
       [HttpPost]
        public IActionResult sil(Models.kutuphane kutuphane)
        {
            var r = Models.kutuphaneVeri.kütüphane1.FirstOrDefault(x => x.kitapNo == kutuphane.kitapNo);
            Models.kutuphaneVeri.kütüphane1.Remove(r);
            return RedirectToAction("listele");
        }
    }
}
