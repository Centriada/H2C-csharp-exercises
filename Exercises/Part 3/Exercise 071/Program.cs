using System;
using System.Collections.Generic;

namespace exercise_71
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
        list.Add(input);
                 
         
      }
        Console.WriteLine("Search for?" );
            int input1 = Convert.ToInt32(Console.ReadLine());
            while (input1 > 0)
            {
               
     
        Console.WriteLine(input1 + " in " + list.IndexOf(input1));
                break;
           }
    }
  }
}
