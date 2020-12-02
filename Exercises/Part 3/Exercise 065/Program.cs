using System;
using System.Collections.Generic;

namespace exercise_65
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
                 int result = list.Count;
                
        if (input == "")
        {
                    Console.WriteLine("The total is: " + result);
          break;

        }
        
        list.Add(input);
            
              
      }
            
    }
  }
}
