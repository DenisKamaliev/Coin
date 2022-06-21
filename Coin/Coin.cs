using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin
{
    internal class Coin
    {
        public static bool Flip(int Player)
        {
            int Random = new Random().Next(2);
            if (Player == Random)
                return true;
            return false;
        }
       
    }
}
