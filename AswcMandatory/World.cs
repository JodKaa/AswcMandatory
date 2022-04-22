using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AswcMandatory.Models;

namespace AswcMandatory
{
    public class World
    {
        /// <summary>
        /// The class for defining the world our creatures will roam in.
        /// </summary>
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public World(int maxX, int maxY)
        {
            this.MaxX = maxX;
            this.MaxY = maxY;
        }
    }
}
