using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          
          //Instantiating an object
          
          Map map = new Map(8, 5);
          
          //Creating a point. Still works as MapLocation Inherits point
          Point mL = new MapLocation(4, 2);
         
          Point p = mL;
          
          map.OnMap(new MapLocation(0, 0));
          
          //Therefore being able to use its public methods
          Console.WriteLine(mL.DistanceTo(5, 5));
          
          Console.WriteLine(mL is MapLocation);
          Console.WriteLine(mL is Point);
          
          Point point = new Point(0, 0);
          Console.WriteLine(point is MapLocation);
        }
    }
}