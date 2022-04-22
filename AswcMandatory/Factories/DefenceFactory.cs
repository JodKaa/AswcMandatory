using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Interfaces;
using AswcMandatory.Models;

namespace AswcMandatory.Factories
{
    public class DefenceFactory : WorldObjectFactory
    {
        /// <summary>
        /// A factory using the abstract factory to create WorldObjects of the type "Defence".
        /// </summary>
        /// <returns></returns>
        public override IWorldObject CreateWorldObject()
        {
            return new DefenceObject(10);
        }
    }
}
