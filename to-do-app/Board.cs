using System.Collections.Generic;

namespace to_do_app
{
  public class Board
  {
    private List<Kart> kartlar;
    public Board(List<Kart> kartlar)
    {
      this.kartlar = kartlar;
    }

    public void KartEkle(Kart kart)
    {
      this.kartlar.Add(kart);
    }

    public Kart KartBul(string baslik)
    {
      Kart bulunanKart = this.kartlar.Find(kart => kart.Baslik == baslik);
      return bulunanKart;
    }

    public void KartSil(Kart kart)
    {
      this.kartlar.Remove(kart);
    }

    public void KartTasi(Kart kart, Durum durum)
    {
      kart.Durum = durum;
    }

    public List<Kart> DurumaGoreFiltrele(Durum durum){
      return this.kartlar.FindAll(kart => kart.Durum == durum);
      
    }
  }
}