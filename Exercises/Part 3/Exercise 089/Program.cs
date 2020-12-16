using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
     while(true)
     {
               string sentance = Console.ReadLine();
                var words = sentance.Split(' ');
       for (int i = 0; i < words.Length; i++)
       {
         if (sentance != "")
         {
              Console.WriteLine(words[words.Length - 1]);    
               break;
         }
          
             
          
       }
     }
    }
  }
}



