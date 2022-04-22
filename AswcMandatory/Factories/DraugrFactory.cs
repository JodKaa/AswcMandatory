using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Interfaces;
using AswcMandatory.Models;

namespace AswcMandatory.Factories
{
    public class DraugrFactory : CreatureFactory
    {
        /// <summary>
        /// A factory using the abstract factory to create creatures of the type "Draugr".
        /// </summary>
        /// <returns></returns>
        public override ICreature CreateCreature()
        {
            return new Creature("Draugr", 60, new Position(0, 0), null, false);
        }
    }
}
