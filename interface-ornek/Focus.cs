namespace interface_ornek{
  public class Focus : IOtomobil
  {
    public Marka HangiMarka()
    {
      return Marka.Ford;
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