using System;

namespace TreehouseDefense
{
  class Point
  {
    public readonly int XCoord;
    public readonly int YCoord;
    
    public Point(int x, int y)
    {
      XCoord = x;
      YCoord = y;
    }
    
    public int DistanceTo(int x, int y)
    {
      //Uses Cartesian Distance Equation with 2 Parameters
      
      //Find the difference between the point we are at and the one we want to reach
      
      int xDiff = XCoord - x;
      int yDiff = YCoord - y;
      
      //Square the differences
      
      int xDiffSquared = xDiff * xDiff;
      int yDiffSquared = yDiff * yDiff;
      
      //Add the squared differences then sqrt them
      
      return (int) Math.Sqrt(xDiffSquared + yDiffSquared);
      
      /* This can be written in a single line like this:
      
        return (int) Math.Sqrt(Math.Pow(XCoord - x, 2) + Math.Pow(YCoord - y, 2));
        
        ADV:
        - Less Variables: Less likely to type wrong one in wrong place
        
        DISADV:
        -No broken up and less readable: Harder to think about
    }
  }
}