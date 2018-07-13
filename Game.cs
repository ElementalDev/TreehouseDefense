using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          
          //Instantiating an object
          
          Map map = new Map(8, 5);
          
          //Creating a point
          Point point = new Point(4, 2);
          
          //Storing whether the point is on the map
          bool isOnMap = map.OnMap(point);
          
          //Print result to console
          
          Console.WriteLine(isOnMap);
          
          //Creating a new point (testing to see if it will go out of bounds)
          point = new Point(8, 5);
          isOnMap = map.OnMap(point);
          
          Console.WriteLine(isOnMap);
        }
    }
}