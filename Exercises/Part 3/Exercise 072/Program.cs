using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
         List<int> list = new List<int>();
             int input;
            
      while (true)
      {
        input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          break;
        }
         list.Add(input);
      }
          int min = list[0];
            
        for (int i = 0; i < list.Count; i++)
        {     
        
         int num = list[i];
        
        if (min > num )
         {
          min = num;
           
          }
        }
           Console.WriteLine("Smallest number is: " + min);
            Console.WriteLine("Found at index " + list.IndexOf(min));
    }
  }
}
