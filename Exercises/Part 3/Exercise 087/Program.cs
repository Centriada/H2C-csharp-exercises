using System;
using System.Collections.Generic;

namespace exercise_87
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

          for(int i = 0; i < words.Length; i++)
          {
              if(words[i].Contains("av"))
              {
                    Console.WriteLine(words[i]);     
              }
              
          }
       } 
    }
   }               
 }          
    
    
         
    

  



