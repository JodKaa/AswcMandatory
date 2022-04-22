using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AswcMandatory
{
    public class Position
    {
        /// <summary>
        /// The class for the creatures' positioning in the game.
        /// </summary>
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
