using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AswcMandatory.Interfaces
{
    public interface IAttackObject : IWorldObject
    {
        int Damage { get; set; }
        int Range { get; set; }
    }
}
