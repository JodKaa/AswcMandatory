using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AswcMandatory.Models
{
    public class AttackObject : WorldObject
    {
        public int Damage { get; set; }
        public int Range { get; set; }

        public AttackObject(int damage, int range)
        {
            this.Damage = damage;
            this.Range = range;
        }
    }
}
