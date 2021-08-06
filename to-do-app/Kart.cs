namespace to_do_app
{
  public class Kart
  {
    private string baslik;
    private string icerik;
    private int atananKisi;
    private Buyukluk buyukluk;
    private Durum durum;

    public Kart(string baslik, string icerik, int atananKisi, Buyukluk buyukluk, Durum durum)
    {
      this.Baslik = baslik;
      this.Icerik = icerik;
      this.AtananKisi = atananKisi;
      this.Buyukluk = buyukluk;
      this.Durum = durum;
    }

    public string Baslik { get => baslik; set => baslik = value; }
    public string Icerik { get => icerik; set => icerik = value; }
    public int AtananKisi { get => atananKisi; set => atananKisi = value; }
    public Buyukluk Buyukluk { get => buyukluk; set => buyukluk = value; }
    public Durum Durum { get => durum; set => durum = value; }
  }
}
