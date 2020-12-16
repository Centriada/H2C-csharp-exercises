using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)

    {
            Console.WriteLine("Enter a sentance");
        while(true)
       {
               string sentance = Console.ReadLine();
                var words = sentance.Split(' ');
             if (sentance != "")
              {
                
                    Console.WriteLine(words[0]);     
              }
             else
            {
             break;   
             }
          
       } 
        
     
    }
  }
}



