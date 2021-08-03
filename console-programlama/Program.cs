using System;

namespace console_programlama
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("Adınızı Giriniz:");
      string firstName = Console.ReadLine();
      Console.WriteLine("Soyadınızı Giriniz:");
      string lastName = Console.ReadLine();
      Console.WriteLine("Merhaba, " + firstName + " " + lastName + "!");
    }
  }
}
