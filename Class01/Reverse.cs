using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01
{
  internal class Reverse
  {
    public static void Rev(int[] arr)
    {
      int[] newArr = new int[arr.Length];
      int counter = 0;

      for(int i = arr.Length - 1; i >= 0; i--)
      {
        newArr[ counter ] = arr[ i ];
        counter++;
      }
      foreach (int num in newArr)
        Console.WriteLine(num);
    }
  }
}
