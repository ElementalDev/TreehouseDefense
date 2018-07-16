namespace TreehouseDefense
{
  class TreehouseDefenseException : System.Exception
  {
    public TreehouseDefenseException
    {
    }
    
    public TreehouseDefenseException(string msg) : base(msg)
    {
    }
  }
  
  class OutOfBoundsException : TreehouseDefenseException
  {
    public OutOfBoundsException()
    {
    }
    
    public OutOfBoundsException(string msg) : base(msg)
    {
    }
  }
}