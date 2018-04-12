using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Players
{
    public class SimpleCheater : Players
    {
        public SimpleCheater(int min, int max, int number) : base(min, max, number)
        {
        }

        public SimpleCheater() { }

        public override void Move(int min, int max, ref int number)
        {
            number = random.Next(min, max);
        }
    }
}
