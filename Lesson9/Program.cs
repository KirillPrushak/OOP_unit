namespace Lesson9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var knight = new Knight();
            var archer = new Archer();
            var mage = new Mage();
            
            //Property of each unit
            knight.Attack();
            archer.Attack();
            mage.Attack();
        }
    }
}