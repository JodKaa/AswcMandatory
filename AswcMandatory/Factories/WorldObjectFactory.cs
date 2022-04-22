using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Interfaces;

namespace AswcMandatory.Factories
{
    /// <summary>
    /// An abstract factory for creating WorldObjects. This can be used by more specific factories.
    /// </summary>
    public abstract class WorldObjectFactory
    {
        public abstract IWorldObject CreateWorldObject();
    }
}
