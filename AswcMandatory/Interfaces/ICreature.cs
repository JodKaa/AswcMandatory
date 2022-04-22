using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Models;

namespace AswcMandatory.Interfaces
{
    public interface ICreature
    {
        string Name { get; set; }
        int Hitpoints { get; set; }
        List<WorldObject> Inventory { get; set; }
        Position position { get; set; }
        bool IsDead { get; set; }
    }
}
