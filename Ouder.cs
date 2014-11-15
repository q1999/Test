using System;
using System.Text;

namespace cSharMisc02
{
  public class Ouder
  {
    private Kind k;

    // public Kind K {
    //   get
    //     {
    //       return k;
    //     }
    //   set
    //     {
    //       k = value;
    //     }
    // }
    
    public Ouder(Kind k)
    {
      this.k = k;
      k.RoepEvent += Antwoord;
    }
    
    public void Antwoord(object sender, EventArgs ea)
      {
        Console.WriteLine("WAT IS ER?");*
      }
  }
}