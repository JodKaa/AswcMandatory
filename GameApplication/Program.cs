using System;
using System.Collections.Generic;
using AswcMandatory;
using AswcMandatory.Factories;
using AswcMandatory.Models;

namespace GameApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //List<WorldObject> playerInventory = new List<WorldObject>();
            //Position playerPosition = new Position(1, 1);

            //Creature player = new Creature("Ragnar", 100, playerPosition, playerInventory, false);

            //Console.WriteLine(player.ToString());
            //player.RecieveHit(50);
            //Console.WriteLine(player.ToString());

            CreatureFactory Draugrfactory = new DraugrFactory();
            Draugrfactory.CreateCreature();
        }
    }
}
