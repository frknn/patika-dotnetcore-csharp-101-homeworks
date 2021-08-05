namespace interface_ornek{
  public class Corolla : IOtomobil
  {
    public Marka HangiMarka()
    {
      return Marka.Toyota;
    }

    public int KacTekerlegiVar()
    {
      return 4;
    }

    public Renk StandartRenk()
    {
      return Renk.Beyaz;
    }
  }
}