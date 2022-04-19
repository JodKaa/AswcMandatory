using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Models;

namespace AswcMandatory
{
    public class Player : Creature
    {
        public Tuple<int, int> Position { get; set; }

        public Player(Tuple<int, int> position)
        {
            this.Position = position;
        }

        public override string ToString()
        {
            return $"{Name}| Hitpoints: {Hitpoints}, Inventory: {Inventory} | Current position: ({Position})";
        }
    }
}
