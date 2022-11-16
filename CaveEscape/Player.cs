using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveEscape
{
    internal class Player
    {
        // fields
        private Room _location; // room the player is currently in

        // constructor
        public Player(Room aRoom)
        {
            _location = aRoom;
        }

        // properties for encapsulation

        internal Room Location { get => _location; set => _location = value; }

        // methods
        public void DisplayLocationDescription()
        {
            Console.WriteLine(System.Environment.NewLine + _location.Description + System.Environment.NewLine);
        }

        public void MoveLocation(Room newLocation)
        {
            Location = newLocation;
        }

    }
}
