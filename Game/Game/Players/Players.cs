using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Players
{
    public abstract class Players
    {
        int min;
        int max;
        int number;

        public Players(int min, int max, int number)
        {
            this.min = min;
            this.max = max;
            this.number = number;
        }

        public Players(){}

        public abstract void Move(int min, int max, ref int number);

        static public Random random = new Random();
    }
}
