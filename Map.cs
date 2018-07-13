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
  }
}