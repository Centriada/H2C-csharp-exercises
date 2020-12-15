using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true)
        {
         string input = Console.ReadLine();

            if (input != ""){
            
             string[] words = input.Split(' ');
                foreach (string value in input)
                     {
                       

                 
                   Console.WriteLine(input.Contains("av"));
                    }
                }
             }
               if (input == "")
               {
                break;
                }
        }
    }

  }

}

