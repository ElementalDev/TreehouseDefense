using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          
          //Instantiating an object
          
          Map map = new Map(8, 5);
          
          try
          {
            MapLocation mapL = new MapLocation(20, 20, map);
          }
          catch(Exception ex)
          {
            Console.WriteLine(ex.Message);
          }
        }
    }
}