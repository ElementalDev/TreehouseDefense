namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          
          //Instantiating an object
          
          Map map = new Map();
          
          map.width = 8;
          map.height = 5;
          
          int area = map.width * map.height;
          
          System.Console.WriteLine(area);
          System.Console.ReadLine();
          
        }
    }
}