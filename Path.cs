namespace TreehouseDefense
{
  class Path
  {
    
    private readonly MapLocation[] _path;
    
    public Path(MapLocation[] path)
    {
      _path = path;
    }
    
    public GetLocationAt(int pathStep)
    {
      try
      {
        return _path[pathStep];
      }
      catch(System.IndexOutOfRangeException)
      {
        return null;
      }
    }
  }
}