using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveEscape
{
    class Program
    {
        static void Main(string[] args)
        {
            GameStart();
        }

        static void GameStart()
        {
            DisplayTitle();

            // create room objects
            Room StartingRoom = new("startingRoom", "You are in a dim, wet cave chamber. To the north, there is a locked iron door. To the South, a passage travels deeper into the cave. To the East, a passage travels deeper into the cave.", "exitRoom", "bucketRoom", "waterRoom", "");
            Room WaterRoom = new("waterRoom", "You are in a vast cave chamber. A pool of water fills much of the chamber. To the West, a passage travels towards light.", "", "", "", "startingRoom");
            Room BucketRoom = new("bucketRoom", "You are in a low cave chamber. A metal bucket rests on the floor. To the North, a passage travels towards light. To the East, a passage travels deeper into the cave.", "startingRoom", "", "fireRoom", "");
            Room FireRoom = new("fireRoom", "You are in a larger cave chamber. A small bonfire burns in the center of the chamber. To the West, a passage travels towards light.", "", "", "", "bucketRoom");
            Room ExitRoom = new("exitRoom", "You are in the mouth of a cave. To the South, an iron door leads deeper into the cave. To the North, you see light and freedom.", "", "startingRoom", "", "");

            // create map dictionary
            Dictionary<string, Room> map = new Dictionary<string, Room>();

            // add room objects to map
            map.Add(StartingRoom.Name, StartingRoom);
            map.Add(WaterRoom.Name, WaterRoom);
            map.Add(BucketRoom.Name, BucketRoom);
            map.Add(FireRoom.Name, FireRoom);
            map.Add(ExitRoom.Name, ExitRoom);

            // create player object
            Player _Player = new(StartingRoom);

            // display starting room location description
            _Player.DisplayLocationDescription();

            // game loop
            do
            {
                // parse player input
                string? command = Console.ReadLine();

                if (command == null)
                {
                    throw new NullReferenceException();
                }
                else if (command.ToLower() == "north")
                {
                    string roomToNorthName = _Player.Location.NorthRoom;
                    if (roomToNorthName == "")
                    {
                        Console.WriteLine(System.Environment.NewLine + "You can't go that way!");
                    }
                    else
                    {
                        _Player.MoveLocation(map[roomToNorthName]);
                    }
                }
                else if (command.ToLower() == "south")
                {
                    string roomToSouthName = _Player.Location.SouthRoom;
                    if (roomToSouthName == "")
                    {
                        Console.WriteLine(System.Environment.NewLine + "You can't go that way!");
                    }
                    else
                    {
                        _Player.MoveLocation(map[roomToSouthName]);
                    }
                }
                else if (command.ToLower() == "east")
                {
                    string roomToEastName = _Player.Location.EastRoom;
                    if (roomToEastName == "")
                    {
                        Console.WriteLine(System.Environment.NewLine + "You can't go that way!");
                    }
                    else
                    {
                        _Player.MoveLocation(map[roomToEastName]);
                    }
                }
                else if (command.ToLower() == "west")
                {
                    string roomToWestName = _Player.Location.WestRoom;
                    if (roomToWestName == "")
                    {
                        Console.WriteLine(System.Environment.NewLine + "You can't go that way!");
                    }
                    else
                    {
                        _Player.MoveLocation(map[roomToWestName]);
                    }
                }
                else
                {
                    Console.WriteLine(System.Environment.NewLine + "Invalid command. Try 'north,' 'south,' 'east,' or 'west.'");
                }

                // display location description
                _Player.DisplayLocationDescription();
            }
            while (_Player.Location != ExitRoom); // game ends when player is in the exit room

            // display victory message
            Console.WriteLine("YOU WIN!");
        }

        static void DisplayTitle()
        {
            Console.WriteLine("   _,.----.    ,---.           ,-.-.    ,----.             ,----.    ,-,--.    _,.----.    ,---.          _ __       ,----.  ");
            Console.WriteLine(" .' .' -   \\ .--.'  \\   ,--.-./=/ ,/ ,-.--` , \\         ,-.--` , \\ ,-.'-  _\\ .' .' -   \\ .--.'  \\      .-`.' ,`.  ,-.--` , \\ ");
            Console.WriteLine("/==/  ,  ,-' \\==\\-/\\ \\ /==/, ||=| -||==|-  _.-`        |==|-  _.-`/==/_ ,_.'/==/  ,  ,-' \\==\\-/\\ \\    /==/, -   \\|==|-  _.-` ");
            Console.WriteLine("|==|-   |  . /==/-|_\\ |\\==\\,  \\ / ,||==|   `.-.        |==|   `.-.\\==\\  \\   |==|-   |  . /==/-|_\\ |  |==| _ .=. ||==|   `.-. ");
            Console.WriteLine("|==|_   `-' \\\\==\\,   - \\\\==\\ - ' - /==/_ ,    /       /==/_ ,    / \\==\\ -\\  |==|_   `-' \\\\==\\,   - \\ |==| , '=',/==/_ ,    / ");
            Console.WriteLine("|==|   _  , |/==/ -   ,| \\==\\ ,   ||==|    .-'        |==|    .-'  _\\==\\ ,\\ |==|   _  , |/==/ -   ,| |==|-  '..'|==|    .-'  ");
            Console.WriteLine("\\==\\.       /==/-  /\\ - \\|==| -  ,/|==|_  ,`-._       |==|_  ,`-._/==/\\/ _ |\\==\\.       /==/-  /\\ - \\|==|,  |   |==|_  ,`-._ ");
            Console.WriteLine(" `-.`.___.-'\\==\\ _.\\=\\.-'\\==\\  _ / /==/ ,     /       /==/ ,     /\\==\\ - , / `-.`.___.-'\\==\\ _.\\=\\.-'/==/ - |   /==/ ,     / ");
            Console.WriteLine("             `--`         `--`--'  `--`-----``        `--`-----``  `--`---'              `--`        `--`---'   `--`-----``  ");
        }
    }
}