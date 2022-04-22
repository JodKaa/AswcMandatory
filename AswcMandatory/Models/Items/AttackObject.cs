using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Interfaces;

namespace AswcMandatory.Models
{
    /// <summary>
    /// This class defines the objects able to deal damage at a certain range. This class inherits from the WorldObject-class.
    /// </summary>
    public class AttackObject : WorldObject
    {
        public int Damage { get; set; }
        public int Range { get; set; }

        /// <summary>
        /// Damage defining the damage dealt with this weapon and its range.
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="range"></param>
        public AttackObject(int damage, int range)
        {
            this.Damage = damage;
            this.Range = range;
        }
    }
}
