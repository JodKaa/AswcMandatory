using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AswcMandatory.Models
{
    public class Creature
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public List<WorldObject> Inventory { get; set; }

        public Creature(string name, int hitpoints, List<WorldObject> inventory)
        {
            this.Name = name;
            this.Hitpoints = hitpoints;
            this.Inventory = inventory;
        }

        public Creature()
        {
        }

        public void Hit(int damage)
        {
            Hitpoints = Hitpoints - damage;
        }

        public void Loot(WorldObject aWorldObject)
        {
            Inventory.Add(aWorldObject);
        }
    }
}
