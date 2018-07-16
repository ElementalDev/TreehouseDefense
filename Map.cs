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
      
      return point.XCoord >= 0 && point.XCoord < Width && 
             point.YCoord >= 0 && point.YCoord < Height;
      
      /* Another way to implement this is like this:
      
       bool inBounds = point.XCord >= 0 && point.XCord < Width && point.YCord >= 0 && point.YCord < Height;
       
       OR
      
      bool inBounds = !(point.XCord < 0 || point.XCord >= Width || point.YCord < 0 || point.YChord >= Height);
      
      ! = NOT operator
      || = OR operator
      && = AND operator
      
      */
    }
  }
}