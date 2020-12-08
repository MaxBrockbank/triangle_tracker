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
      else if(a != b && b != c && c != a && a + b == c)
      {
        return true;
      }
      else if((a==b && (a+b) > c) || (b==c && (b+c) >a ) || (c == a && (c+a) > b))
      {
        return true;
      } 
      else
      {
        return false;
      }
      
    }
  }
}
