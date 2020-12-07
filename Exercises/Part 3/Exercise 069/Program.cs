using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
      while (true)
       {
                    int max = 0;
                    int min = 0;
          input = Convert.ToInt32(Console.ReadLine());
               foreach (int value in list)
                {
                        if (value <= max && value >= min)
        Console.WriteLine(max);
                }
                    list.Add(input);
            
           
       }
        
      }    
    }
  }
}
