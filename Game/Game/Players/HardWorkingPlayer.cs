using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Players
{
    public class HardWorkingPlayer : Players
    {
        public HardWorkingPlayer(int min, int max, int number) : base(min, max, number)
        {
        }

        public HardWorkingPlayer(){ }

        public override void Move(int min, int max, ref int number)
        {
            if (number > min && number < max)
                number += 1;
            else
                number = min + 1;
        }
    }
}
