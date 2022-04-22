using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory;
using AswcMandatory.Models;

namespace GameApplication
{
    public class Player : Creature
    {
        public Player(string name, int hitpoints, List<WorldObject> inventory, Position position, bool isDead)
        {
            this.Name = name;
            this.Hitpoints = hitpoints;
            this.Inventory = inventory;
            this.position = position;
            this.IsDead = isDead;
        }
    }
}
