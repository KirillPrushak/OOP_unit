namespace Lesson9
{
    internal class Characher
    {
        public static void Main(string[] args)
        {
            var knight = new Knight()
            {
                Damage = 10,
                HP = 50,
                Force = 20
            };
            var archer = new Archer()
            {
                Damage = 8,
                HP = 45,
                Force = 10
            };
            var mage = new Mage()
            {
                Damage = 15,
                HP = 35,
                Force = 8
            };
            
            //Property of each unit
            knight.Attack();
            archer.Attack();
            mage.Attack();
        }
    }
}