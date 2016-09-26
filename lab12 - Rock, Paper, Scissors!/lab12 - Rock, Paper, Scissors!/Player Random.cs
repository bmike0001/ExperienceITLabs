using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12___Rock__Paper__Scissors_
{
    class Player_Random : Player
    {
        public override Roshambo generateRoshambo()
        {
            Random roshamboRandomGenerator = new Random();
           int selectNum =  roshamboRandomGenerator.Next(1,4);
            return (Roshambo)selectNum;
    
           //random number 
           // random num pick roshambo num
           //return value
        }
    }

}

