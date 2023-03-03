using System;

namespace Lesson9
{
    public class Knight: Unit
    {
        public int Damage { get; set; }
        public int HP { get; set; }
        public int Force { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Knight kills a enemy with sword: Damage - {Damage}, HP - {HP}, Force - {Force}");
        }
    }
}