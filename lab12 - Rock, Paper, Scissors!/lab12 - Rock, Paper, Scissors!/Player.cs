using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12___Rock__Paper__Scissors_
{
    public abstract class Player
    {
       public Roshambo playerChoice = Roshambo.paper;
       public string name = "";
      public abstract Roshambo generateRoshambo();

    }
}
