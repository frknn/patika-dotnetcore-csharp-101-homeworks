using System;
using System.Collections.Generic;

namespace to_do_app
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<int, string> kisiler = new Dictionary<int, string>(){
        {1,"Furkan"},
        {2,"Hakan"},
        {3,"Mehmet"},
        {4,"Sukran"}
      };

      List<Kart> kartlar = new List<Kart>(){
        new Kart("Odeme Islemleri", "Odeme API'si baglanacak.",1,Buyukluk.XS,Durum.TODO),
        new Kart("Loglama", "Loglama arayuzu yazilacak.",2,Buyukluk.S,Durum.TODO),
        new Kart("Database", "Database kurulumu yapilacak.",3,Buyukluk.M,Durum.TODO),
      };

      Board board = new Board(kartlar);

      while (true)
      {
        KonsoluTemizle();
        MenuyuGoster();
        string girdi = Console.ReadLine();

        switch (girdi)
        {
          case "1":
            KonsoluTemizle();
            KartlariListele();
            MenuyeDon();
            break;

          case "2":
            KonsoluTemizle();
            KartEkle();
            MenuyeDon();
            break;

          case "3":
            KonsoluTemizle();
            KartSil();
            MenuyeDon();
            break;

          case "4":
            KonsoluTemizle();
            KartTasi();
            MenuyeDon();
            break;

          case "5":
            return;

          default:
            Console.WriteLine("Lutfen gecerli bir secim yapiniz.");
            break;
        }
      }

      void KartlariListele()
      {
        List<Kart> toDoKartlar = board.DurumaGoreFiltrele(Durum.TODO);
        List<Kart> inProgressKartlar = board.DurumaGoreFiltrele(Durum.IN_PROGRESS);
        List<Kart> doneKartlar = board.DurumaGoreFiltrele(Durum.DONE);

        Console.WriteLine("TODO Line");
        Console.WriteLine("********************");
        if (toDoKartlar.Count > 0) ListeyiYazdir(toDoKartlar);
        else Console.WriteLine("~ BOŞ ~\n");

        Console.WriteLine("IN PROGRESS Line");
        Console.WriteLine("********************");
        if (inProgressKartlar.Count > 0) ListeyiYazdir(inProgressKartlar);
        else Console.WriteLine("~ BOŞ ~\n");

        Console.WriteLine("DONE Line");
        Console.WriteLine("********************");
        if (doneKartlar.Count > 0) ListeyiYazdir(doneKartlar);
        else Console.WriteLine("~ BOŞ ~\n");
      }
      void KartEkle()
      {
        Console.Write("Baslik Giriniz".PadRight(48) + ": ");
        string baslik = Console.ReadLine();

        Console.Write("Icerik Giriniz".PadRight(48) + ": ");
        string icerik = Console.ReadLine();

        string buyukluk;
        while (true)
        {
          Console.Write("Buyukluk Seciniz -> XS(1),(2)S,(3)M,(4)L,(5)XL".PadRight(48) + ": ");
          string girdi = Console.ReadLine();
          if (GirdiGecerliMi(girdi, "1", "2", "3", "4", "5"))
          {
            buyukluk = girdi;
            break;
          }
          else
          {
            Console.WriteLine("Lutfen 1,2,3,4 ya da 5 giriniz.");
          }
        }

        Console.Write("Kisi ID'si giriniz".PadRight(48) + ": ");
        int atanacakKisi = int.Parse(Console.ReadLine());
        if (!kisiler.ContainsKey(atanacakKisi))
        {
          Console.WriteLine("Kisi bulunamadi! Islem iptal edildi.");
          return;
        }

        string durum;
        while (true)
        {
          Console.Write("Durum Seciniz -> (1)TODO,(2)IN PROGRESS,(3)DONE".PadRight(48) + ": ");
          string girdi = Console.ReadLine();
          if (GirdiGecerliMi(girdi, "1", "2", "3"))
          {
            durum = girdi;
            break;
          }
          else
          {
            Console.WriteLine("Lutfen 1,2 ya da 3 giriniz.");
          }
        }

        Kart yeniKart = new Kart(baslik, icerik, atanacakKisi, (Buyukluk)int.Parse(buyukluk), (Durum)int.Parse(durum));
        board.KartEkle(yeniKart);
        Console.WriteLine("Kart Eklendi!");

      }
      void KartSil()
      {
        while (true)
        {
          Console.Write("Silmek Istediginiz Kartin Basligini Giriniz: ");
          string baslik = Console.ReadLine();
          Kart kart = board.KartBul(baslik);
          if (kart == null)
          {
            Console.WriteLine("Aradiginiz kart bulunamadi. Lutfen bir secim yapin.");
            Console.WriteLine("(1) Silmeyi sonlandir.");
            Console.WriteLine("(2) Yeniden dene.");
            string girdi = Console.ReadLine();
            switch (girdi)
            {
              case "1":
                Console.WriteLine("Silme sonlandirildi!");
                return;

              case "2":
                break;

              default:
                Console.WriteLine("Yanlis secim yaptiginiz icin islem sonlandirildi!");
                return;
            }
          }
          else
          {
            board.KartSil(kart);
            Console.WriteLine(kart.Baslik + " baslikli kart silindi!.");
            return;
          }
        }

      }
      void KartTasi()
      {
        while (true)
        {
          Console.Write("Guncellemek Istediginiz Kartin Basligini Giriniz: ");
          string baslik = Console.ReadLine();
          Kart kart = board.KartBul(baslik);
          if (kart == null)
          {
            Console.WriteLine("Aradiginiz kart bulunamadi. Lutfen bir secim yapin.");
            Console.WriteLine("(1) Guncellemeyi sonlandir.");
            Console.WriteLine("(2) Yeniden dene.");
            string girdi = Console.ReadLine();
            switch (girdi)
            {
              case "1":
                Console.WriteLine("Guncelleme sonlandirildi!");
                return;

              case "2":
                break;

              default:
                Console.WriteLine("Yanlis secim yaptiginiz icin islem sonlandirildi!");
                return;
            }
          }
          else
          {
            Console.WriteLine("Bulunan Kart Bilgileri: ");
            Console.WriteLine("*************************");
            KartiYazdir(kart);
            Console.WriteLine("\n");
            while (true)
            {
              Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
              Console.WriteLine("(1) TODO - (2) IN PROGRESS - (3)DONE");
              string durum = Console.ReadLine();
              if (GirdiGecerliMi(durum, "1", "2", "3"))
              {
                board.KartTasi(kart, (Durum)int.Parse(durum));
                Console.WriteLine(kart.Baslik + " baslikli kart tasindi!");
                KartlariListele();
                return;
              }
              else
              {
                Console.WriteLine("Lutfen 1,2 ya da 3 giriniz.");
              }
            }
          }
        }
      }
      void KonsoluTemizle()
      {
        Console.Clear();
      }
      void MenuyuGoster()
      {
        Console.WriteLine("Lütfen yapmak istediginiz islemi seciniz: ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("(1) Board'u Listele");
        Console.WriteLine("(2) Kart Ekle");
        Console.WriteLine("(3) Kart Sil");
        Console.WriteLine("(4) Kart Tasi");
        Console.WriteLine("(5) Uygulamayi Sonlandir");
        Console.Write("Seciminiz: ");
      }
      void MenuyeDon()
      {
        Console.Write("Menuye donmek icin herhangi bir tusa basiniz: ");
        Console.ReadLine();
      }
      void ListeyiYazdir(List<Kart> kartlar)
      {
        foreach (Kart kart in kartlar)
        {
          KartiYazdir(kart);
          Console.WriteLine("-");
        }
      }
      void KartiYazdir(Kart kart)
      {
        Console.WriteLine("Baslik".PadRight(12) + ": " + kart.Baslik);
        Console.WriteLine("Icerik".PadRight(12) + ": " + kart.Icerik);
        Console.WriteLine("Atanan Kisi".PadRight(12) + ": " + kisiler[kart.AtananKisi]);
        Console.WriteLine("Buyukluk".PadRight(12) + ": " + kart.Buyukluk);
      }
      bool GirdiGecerliMi(string girdi, params string[] secenekler)
      {
        if (Array.Exists(secenekler, eleman => eleman == girdi))
          return true;
        else
          return false;
      }
    }
  }
}
