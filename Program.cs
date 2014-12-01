using System;
using System.Text;

namespace cSharMisc02
{
  public class Program
  {
    /// <summary>
    ///   
    /// </summary>
    public static void Main(String[] args)
      {
        Kind kind1 = new Kind();
        Ouder ouder1 = new Ouder(kind1);
        kind1.Roep();
      }
  }
}