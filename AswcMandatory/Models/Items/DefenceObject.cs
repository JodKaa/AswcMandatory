using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AswcMandatory.Models
{
    public class DefenceObject : WorldObject
    {
        public int ReduceDamage { get; set; }

        public DefenceObject(int reduceDamage)
        {
            this.ReduceDamage = reduceDamage;
        }
    }
}
