using System;

namespace Lesson9
{
    public class Archer : Unit
    {
        public int Damage { get; set; }
        public int HP { get; set; }
        public int Force { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Archer kills a enemy with onion: Damage - {Damage}, HP - {HP}, Force - {Force}");
        }
    }
}