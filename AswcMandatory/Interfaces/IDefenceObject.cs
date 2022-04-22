using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AswcMandatory.Interfaces
{
    public interface IDefenceObject : IWorldObject
    {
        int ReduceDamage { get; set; }
    }
}
