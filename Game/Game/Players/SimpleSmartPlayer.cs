
namespace Game.Players
{
    public class SimpleSmartPlayer : Players
    {
        public SimpleSmartPlayer(int min, int max, int number) : base(min, max, number)
        {
        }

        public SimpleSmartPlayer() { }

        public override void Move(int min, int max, ref int number)
        {
            number = random.Next(min, max);
        }
    }
}
