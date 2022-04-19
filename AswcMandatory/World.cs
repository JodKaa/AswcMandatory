using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Models;

namespace AswcMandatory
{
    public class World
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public World(int maxX, int maxY)
        {
            this.MaxX = maxX;
            this.MaxY = maxY;
        }

        public static void Main(string[] args)
        {
            Creature c1 = new Creature("Bjørn Ironside", 100, null);
            Creature c2 = new Creature("Ivar The Boneless", 100, null);

            Console.WriteLine("=================================");
            Console.WriteLine();
            c2.Hit(50);
            Console.WriteLine($"{c2.Name} has been dealt 50 damage! {c2.Name}' health is now {c2.Hitpoints}");
        }
    }
}
