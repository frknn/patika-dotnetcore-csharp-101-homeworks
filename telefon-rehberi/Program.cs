using System;
using System.Collections.Generic;

namespace telefon_rehberi
{
  class Program
  {
    static void Main(string[] args)
    {
      Rehber telefonRehberi = new Rehber();

      while (true)
      {
        KonsoluTemizle();
        MenuyuGoster();
        int girdi = int.Parse(Console.ReadLine());
        switch (girdi)
        {
          case 1:
            KonsoluTemizle();
            NumaraKaydet();
            MenuyeDon();
            break;

          case 2:
            KonsoluTemizle();
            NumaraSil();
            MenuyeDon();
            break;

          case 3:
            KonsoluTemizle();
            NumaraGuncelle();
            MenuyeDon();
            break;

          case 4:
            KonsoluTemizle();
            KisileriListele();
            MenuyeDon();
            break;

          case 5:
            KonsoluTemizle();
            AramaYap();
            MenuyeDon();
            break;

          case 6:
            KonsoluTemizle();
            return;

          default:
            break;
        }
      }

      void MenuyuGoster()
      {
        Console.WriteLine("Lütfen yapmak istediginiz islemi seciniz: ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("(1) Yeni Numara Kaydet");
        Console.WriteLine("(2) Varolan Numarayi Sil");
        Console.WriteLine("(3) Varolan Numarayi Guncelle");
        Console.WriteLine("(4) Rehberi Listele");
        Console.WriteLine("(5) Rehberde Arama Yap");
        Console.WriteLine("(6) Uygulamayi Sonlandir");
        Console.Write("Seciminiz: ");
      }

      void NumaraKaydet()
      {
        Console.WriteLine("Adi: ");
        string ad = Console.ReadLine();
        Console.WriteLine("Soyadi: ");
        string soyad = Console.ReadLine();
        Console.WriteLine("Numarasi: ");
        string no = Console.ReadLine();

        telefonRehberi.NumaraKaydet(ad, soyad, no);
        Console.WriteLine("Numara Kaydedildi!");
      }

      void NumaraSil()
      {
        while (true)
        {
          Console.WriteLine("Silinecek Kisinin Adi veya Soyadi: ");
          string adVeyaSoyad = Console.ReadLine();
          Kisi silinecekKisi = telefonRehberi.AdaGoreKisiBul(adVeyaSoyad);
          if (silinecekKisi == null)
          {
            Console.WriteLine("Aranan kisi bulunamadı. Lutfen bir secim yapin: ");
            Console.WriteLine("Silmeyi sonlandirmak icin: (1)");
            Console.WriteLine("Yeniden denemek icin: (2)");

            string secim = Console.ReadLine();

            switch (secim)
            {
              case "1":
                Console.WriteLine("Silme sonlandirildi!");
                return;

              case "2":
                break;

              default:
                Console.WriteLine("Lutfen '1' ya da '2' giriniz!");
                Console.WriteLine("Silme sonlandirildi!");
                return;
            }
          }
          else
          {
            while (true)
            {
              Console.WriteLine("{0} rehberden silinecek. Onaylıyor musunuz? (y/n)", adVeyaSoyad);
              string onay = Console.ReadLine();
              switch (onay)
              {
                case "y":
                  telefonRehberi.NumaraSil(silinecekKisi);
                  Console.WriteLine("Numara silindi!");
                  return;

                case "n":
                  Console.WriteLine("İşlem iptal edildi!");
                  return;

                default:
                  Console.WriteLine("Lutfen 'y' ya da 'n' giriniz!");
                  break;
              }
            }
          }

        }
      }

      void NumaraGuncelle()
      {
        while (true)
        {
          Console.WriteLine("Guncellenecek Kisinin Adi veya Soyadi: ");
          string adVeyaSoyad = Console.ReadLine();
          Kisi guncellenecekKisi = telefonRehberi.AdaGoreKisiBul(adVeyaSoyad);
          if (guncellenecekKisi == null)
          {
            Console.WriteLine("Aranan kisi bulunamadı. Lutfen bir secim yapin: ");
            Console.WriteLine("Guncellemeyi sonlandirmak icin: (1)");
            Console.WriteLine("Yeniden denemek icin: (2)");

            string secim = Console.ReadLine();

            switch (secim)
            {
              case "1":
                Console.WriteLine("Guncelleme sonlandirildi!");
                return;

              case "2":
                break;

              default:
                Console.WriteLine("Lutfen '1' ya da '2' giriniz!");
                Console.WriteLine("Guncelleme sonlandirildi!");
                return;
            }
          }
          else
          {
            Console.WriteLine("Yeni Numarayi Giriniz: ");
            string yeniNumara = Console.ReadLine();
            telefonRehberi.NumaraGuncelle(guncellenecekKisi, yeniNumara);
            Console.WriteLine("Numara Guncellendi!");
            return;
          }

        }
      }

      void KisileriListele()
      {
        while (true)
        {
          Console.WriteLine("(1) A-Z - (2) Z-A");
          Console.WriteLine("Seciminiz: ");
          string girdi = Console.ReadLine();
          KonsoluTemizle();
          switch (girdi)
          {
            case "1":
              Console.WriteLine("\n\n\nTelefon Rehberi");
              ListeyiYazdir(telefonRehberi.ListeyiDondur());
              return;
            case "2":
              Console.WriteLine("\n\n\nTelefon Rehberi");
              ListeyiYazdir(telefonRehberi.ListeyiDondur(true));
              return;
            default:
              Console.WriteLine("Lütfen '1' ya da '2' giriniz.");
              break;
          }
        }
      }

      void AramaYap()
      {
        while (true)
        {
          Console.WriteLine("Arama yapmak istediginiz tipi seciniz.");
          Console.WriteLine("--------------------------------------");
          Console.WriteLine("İsme veya soyisme gore arama yapmak icin: (1)");
          Console.WriteLine("Telefon numarasina gore arama yapmak icin: (2)");
          string girdi = Console.ReadLine();
          List<Kisi> kisiler;
          switch (girdi)
          {
            case "1":
              Console.WriteLine("İsim veya soyismi giriniz: ");
              string adVeyaSoyad = Console.ReadLine();
              kisiler = telefonRehberi.AdaGoreKisileriBul(adVeyaSoyad);
              if (kisiler.Count == 0)
              {
                Console.WriteLine("Arama kriterine gore kisi bulunamadi.");
              }
              else
              {
                ListeyiYazdir(kisiler);
              }
              return;

            case "2":
              Console.WriteLine("Telefon numarasini giriniz: ");
              string no = Console.ReadLine();
              kisiler = telefonRehberi.NumarayaGoreKisileriBul(no);
              if (kisiler.Count == 0)
              {
                Console.WriteLine("Arama kriterine gore kisi bulunamadi.");
              }
              else
              {
                ListeyiYazdir(kisiler);
              }
              return;
            default:
              Console.WriteLine("Lutfen '1' ya da '2' giriniz.");
              break;
          }
        }
      }

      void ListeyiYazdir(List<Kisi> kisiler)
      {
        Console.WriteLine("".PadLeft(50, '-'));
        foreach (Kisi kisi in kisiler)
        {
          Console.WriteLine(("| " + "İsim: " + kisi.Ad).PadRight(50) + "|");
          Console.WriteLine(("| " + "Soyisim: " + kisi.Soyad).PadRight(50) + "|");
          Console.WriteLine(("| " + "Telefon No: " + kisi.TelNo).PadRight(50) + "|");
          // Console.WriteLine("|-".PadRight(50, '-') + "|");
          Console.WriteLine("|".PadRight(50) + "|");
        }
        Console.WriteLine("".PadLeft(50, '-'));
      }

      void KonsoluTemizle()
      {
        Console.Clear();
      }

      void MenuyeDon()
      {
        Console.Write("Menuye donmek icin herhangi bir tusa basiniz: ");
        Console.ReadLine();
      }
    }

  }
}
