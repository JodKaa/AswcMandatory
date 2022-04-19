using System;
using AswcMandatory.Models;

namespace GameApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Creature c1 = new Creature("Bjørn Ironside", 100, null);
            Creature c2 = new Creature("Ivar The Boneless", 100, null);

            Console.WriteLine("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
            Console.WriteLine();
            Console.WriteLine($"Oh wow! {c1.Name} and {c2.Name} are facing off in a 1v1 battle!");
            Console.WriteLine($"{c1.Name} has {c1.Hitpoints} points of health and {c2.Name} has {c2.Hitpoints}.");
            Console.WriteLine();
            Console.WriteLine($"{c1.Name} is attacking {c2.Name} for 50 hitpoints!");
            c2.Hit(50);
            Console.WriteLine($"{c2.Name} has been dealt 50 damage! {c2.Name}' health is now {c2.Hitpoints}");
            Console.WriteLine();        
            Console.WriteLine("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
        }
    }
}
