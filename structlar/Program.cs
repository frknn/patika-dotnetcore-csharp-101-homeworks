using System;

namespace structlar
{
  class Program
  {
    static void Main(string[] args)
    {
      Dikdortgen diktorgen = new Dikdortgen();
      diktorgen.kisaKenar = 3;
      diktorgen.uzunKenar = 4;
      Console.WriteLine("Class Alan Hesabi: {0}", diktorgen.AlanHesapla());

      Dikdortgen_Struct diktorgenStruct = new Dikdortgen_Struct();
      diktorgenStruct.kisaKenar = 3;
      diktorgenStruct.uzunKenar = 4;
      Console.WriteLine("Struct Alan Hesabi: {0}", diktorgenStruct.AlanHesapla());
    }
  }

  class Dikdortgen
  {
    public int kisaKenar;
    public int uzunKenar;

    public long AlanHesapla()
    {
      return this.kisaKenar * this.uzunKenar;
    }
  }

  // Struct'larda parametresiz default Constructor kullanılamaz!
  struct Dikdortgen_Struct
  {
    public int kisaKenar;
    public int uzunKenar;

    public long AlanHesapla()
    {
      return this.kisaKenar * this.uzunKenar;
    }
  }
}
