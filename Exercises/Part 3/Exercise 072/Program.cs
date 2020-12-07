using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
         List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          break;
        }
          int min = 0;
            int max = 0;
        for (int i = 0; i < list.Count; i++)
        {
        if (list[i] < min)
         {
          min = list[i];
          }
        if (list[i] > max)
         {
          max = list[i];
          }
        list.Add(input);
        }
      }
    }
  }
}
