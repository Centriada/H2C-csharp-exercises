using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)

    {
           
        while (true)
        {
            string input = Console.ReadLine();
            if (input != "")
             {
             string[] words = input.Split(' ');
                    foreach(string word in words)
                    {
                   Console.WriteLine(word.Substring(0));
                    }
            } 
               else
             {
                break;
                }
         }    
        
     
    }
  }
}



