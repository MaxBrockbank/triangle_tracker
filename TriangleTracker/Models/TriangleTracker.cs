using System;
using System.Collections.Generic;

namespace TriangleTracker
{
  public class Triangle
  {
    public bool TriangleType(int a, int b, int c )
    {
      if (a == b && b == c && c == a)
      {
        return true;
      }
      return false;
    }
  }
}
