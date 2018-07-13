namespace TreehouseDefense
{
  class Map
  {
    //Fields for class (Private by default)
    //Read only makes it so that the variable can't be changed once initialised
    
    public readonly int Width;
    public readonly int Height;
    
    //Constuctor for map: Initialises the object
    
    public Map(int width, int height)
    {   
      Width = width;
      Height = height;
    }
    
    //Method that determines whether a given point is within the bounds of the map
    
    public bool OnMap(Point point)
    {
      
      //This will return true if all of these conditions are true.
        //NTS: Dont need to use an if statement for every time you need a boolean result
      
      bool inBounds = point.XCord >= 0 && point.XCord < Width && point.YCord >= 0 && point.YCord < Height;
      
      /* Another way to implement this is like this:
      
      bool inBounds = !(point.XCord < 0 || point.XCord >= width || point.YCord < 0 || point.YChord >= height);
      
      ! = NOT operator
      || = OR operator
      && = AND operator
      
      */
      
      return inBounds;
    }
  }
}