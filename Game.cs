namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          
          //Instantiating an object
          
          Map map = new Map(8, 5);
          
          //Assigning the fields to a variable
          
          int area = map.Width * map.Height;
          
          //Printing result out to the console
          
          System.Console.WriteLine(area);
          System.Console.ReadLine();
          
        }
    }
}