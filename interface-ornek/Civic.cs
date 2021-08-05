namespace interface_ornek {
  public class Civic : IOtomobil
  {
    public Marka HangiMarka()
    {
      return Marka.Honda;
    }

    public int KacTekerlegiVar()
    {
      return 4;
    }

    public Renk StandartRenk()
    {
      return Renk.Gri;
    }
  }
}