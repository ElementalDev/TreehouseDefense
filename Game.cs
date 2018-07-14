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
          
          Console.WriteLine(point.DistanceTo(5, 5));
        }
    }
}