namespace telefon_rehberi
{
  public class Kisi
  {
    private string ad;
    private string soyad;
    private string telNo;

    public Kisi(string ad, string soyad, string telNo)
    {
      this.Ad = ad;
      this.Soyad = soyad;
      this.TelNo = telNo;
    }

    public string Ad { get => ad; set => ad = value; }
    public string Soyad { get => soyad; set => soyad = value; }
    public string TelNo { get => telNo; set => telNo = value; }
  }
}