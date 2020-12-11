using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      } 
      Console.WriteLine("Search for?");
      string input1 = Console.ReadLine();
            bool found = false;
       for (int i = 0; i < list.Count; i++)
           if (input1 == list[i])
            {
            Console.WriteLine(input1 + " was found");
                    found = true;
           }         
                    if (!found)
                    { 
                    Console.WriteLine(input1 + " was not found");
                    }
           
          
                  
         
      
    }
  }
}

