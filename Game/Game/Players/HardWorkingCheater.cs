using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Players
{
    public class HardWorkingCheater : Players
    {
        public HardWorkingCheater(int min, int max, int number) : base(min, max, number)
        {
        }

        public HardWorkingCheater() { }

        public override void Move(int min, int max, ref int number)
        {
            if (number > min && number < max)
                number += 1;
            else
                number = min + 1;
        }
    }
}
