using System;
using System.Text;

namespace cSharMisc02
{
  public class Kind
  {
    public event EventHandler RoepEvent;
    /// <summary>
    /// put your summary here!
    /// </summary>
    public void Roep()
      {
        Console.WriteLine("MAMA, PAPA.....");
        if(RoepEvent != null)
          {
            RoepEvent(this, EventArgs.Empty);
          }
      }
  }
}