using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Interfaces;
using AswcMandatory.Models;

namespace AswcMandatory.Factories
{
    /// <summary>
    /// An abstract factory for creating Creatures. This can be used by more specific factories.
    /// </summary>
    public abstract class CreatureFactory
    {
        public abstract ICreature CreateCreature();
    }
}
