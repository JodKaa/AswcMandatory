using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Interfaces;

namespace AswcMandatory.Models
{
    /// <summary>
    /// This class defines protective objects found in our game world.
    /// </summary>
    public class DefenceObject : WorldObject, IWorldObject
    {
        public int ReduceDamage { get; set; }

        /// <summary>
        /// This defines how incoming damage will be reduced by equipping it.
        /// </summary>
        /// <param name="reduceDamage"></param>
        public DefenceObject(int reduceDamage)
        {
            this.ReduceDamage = reduceDamage;
        }
    }
}
