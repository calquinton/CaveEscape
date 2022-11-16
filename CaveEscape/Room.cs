using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveEscape
{
    internal class Room
    {
        // fields
        private string _name;
        private string _description;
        private string _northRoom;
        private string _southRoom;
        private string _eastRoom;
        private string _westRoom;

        // constructor
        public Room(string roomName, string roomDescription, string roomToNorth, string roomToSouth, string roomToEast, string roomToWest)
        {
            _name = roomName;
            _description = roomDescription;
            _northRoom = roomToNorth;
            _southRoom = roomToSouth;
            _eastRoom = roomToEast;
            _westRoom = roomToWest;
        }

        // properties for encapsulation
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string NorthRoom { get => _northRoom; set => _northRoom = value; }
        public string SouthRoom { get => _southRoom; set => _southRoom = value; }
        public string EastRoom { get => _eastRoom; set => _eastRoom = value; }
        public string WestRoom { get => _westRoom; set => _westRoom = value; }
    }
}
