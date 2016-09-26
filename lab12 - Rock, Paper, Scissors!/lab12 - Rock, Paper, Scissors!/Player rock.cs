using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12___Rock__Paper__Scissors_
{
    public class Player_rock : Player
    {
        public override Roshambo generateRoshambo()
        {
           return Roshambo.rock;

        }
    }
}
