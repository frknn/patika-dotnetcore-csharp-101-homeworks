using System;
using System.Linq;
using System.Collections.Generic;

namespace telefon_rehberi
{
  public class Rehber
  {
    private List<Kisi> telefonRehberi = new List<Kisi>(){
        new Kisi("Furkan","Setbasi","5536678994"),
        new Kisi("Mert","Karagoz","5415698652"),
        new Kisi("Salih","Yesildag","5523697842"),
        new Kisi("Ayse","Elmas","5415986363"),
        new Kisi("Zeynep","Akdag","5452369184"),
  };

    private void RehbereEkle(Kisi kisi)
    {
      this.telefonRehberi.Add(kisi);
    }

    public void NumaraKaydet(string ad, string soyad, string no)
    {
      Kisi yeniKisi = new Kisi(ad, soyad, no);
      this.RehbereEkle(yeniKisi);
    }

    public List<Kisi> ListeyiDondur(bool ZdenAya = false)
    {
      List<Kisi> kisiler = telefonRehberi.OrderBy(kisi => kisi.Ad).ToList();
      if (ZdenAya)
      {
        kisiler.Reverse();
      }
      return kisiler;

    }

    public List<Kisi> AdaGoreKisileriBul(string adVeyaSoyad)
    {
      List<Kisi> bulunanKisiler = telefonRehberi.FindAll(
        kisi => kisi.Ad == adVeyaSoyad ||
        kisi.Soyad == adVeyaSoyad
     );
      return bulunanKisiler;
    }

    public Kisi AdaGoreKisiBul(string adVeyaSoyad)
    {
      Kisi bulunanKisi = telefonRehberi.Find(
        kisi => kisi.Ad == adVeyaSoyad ||
        kisi.Soyad == adVeyaSoyad
       );
       return bulunanKisi;
    }
    public List<Kisi> NumarayaGoreKisileriBul(string no)
    {
      List<Kisi> bulunanKisiler = telefonRehberi.FindAll(kisi => kisi.TelNo == no);
      return bulunanKisiler;
    }

    public void NumaraSil(Kisi kisi)
    {
      this.telefonRehberi.Remove(kisi);
    }

    public void NumaraGuncelle(Kisi kisi, string yeniNumara)
    {
      kisi.TelNo = yeniNumara;
    }

  }
}