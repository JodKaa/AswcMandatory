using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AswcMandatory.Models
{
    /// <summary>
    /// This class defines the objects spread across our game world.
    /// </summary>
    public class WorldObject
    {
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removable { get; set; }

        /// <summary>
        /// A name for our object, a boolean telling us if it is lootable (so the player can equip the object) and if it is consumable (removable).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lootable"></param>
        /// <param name="removable"></param>
        public WorldObject(string name, bool lootable, bool removable)
        {
            this.Name = name;
            this.Lootable = lootable;
            this.Removable = removable;
        }

        public WorldObject()
        {
        }
    }
}
