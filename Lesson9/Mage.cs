using System;

namespace Lesson9
{
    public class Mage : Unit
    {
        public int Damage { get; set; }
        public int HP { get; set; }
        public int Force { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Mage kills a enemy with fire magic: Damage - {Damage}, HP - {HP}, force - {Force}");
        }
    }
}