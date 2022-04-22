using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Interfaces;

namespace AswcMandatory.Models
{
    public class Creature : ICreature
    {
        /// <summary>
        /// An abstract class for creatures. It could be either heroes or foes.
        /// </summary>
        
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public List<WorldObject> Inventory { get; set; }
        public Position position { get; set; }
        public bool IsDead { get; set; }

        /// <summary>
        /// The constructor for the creature class, for later use we are able to generate creature objects to our liking.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hitpoints"></param>
        /// <param name="position"></param>
        /// <param name="inventory"></param>
        /// <param name="isDead"></param>
        public Creature(string name, int hitpoints, Position position, List<WorldObject> inventory, bool isDead)
        {
            this.Name = name;
            this.Hitpoints = hitpoints;
            this.Inventory = inventory;
            this.position = position;
            this.IsDead = isDead;
        }

        /// <summary>
        /// An empty (overloaded) constructor for third-parties.
        /// </summary>
        public Creature()
        {
        }

        /// <summary>
        /// The method for dealing damage.
        /// </summary>
        /// <param name="damage"></param>
        /// <returns></returns>
        public int Hit(int damage)
        {
            return damage;
        }

        /// <summary>
        /// The method needed for recieving damage. This method takes the current Hitpoints value, and subtracts the damage dealt.
        /// If the damage dealt is greater than, or equal to the hitpoints left - the IsDead boolean is changed to true.
        /// </summary>
        /// <param name="damage"></param>
        public void RecieveHit(int damage)
        {
            Hitpoints = Hitpoints - damage;
            if (Hitpoints <= 0)
            {
                IsDead = true;
            }
        }

        /// <summary>
        /// The method for looting WorldObjects. This adds the looted item to a List of WorldObjects named inventory.
        /// </summary>
        /// <param name="aWorldObject"></param>
        public void Loot(WorldObject aWorldObject)
        {
            Console.WriteLine($"You looted: {aWorldObject}!");
            Inventory.Add(aWorldObject);
        }

        /// <summary>
        /// An overwriting of the ToString-method to be able to return all values of a Creature object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"This is {Name}| Hitpoints: {Hitpoints}| Position: {position}| Is {Name} dead?: {IsDead}";
        }
    }
}
