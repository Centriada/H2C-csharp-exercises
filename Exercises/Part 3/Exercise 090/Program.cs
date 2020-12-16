using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
         int ages;
      int highestAge = 0;
      
        Console.WriteLine("Please give name and age");
            string input;
        while (true)
        {
            input = Console.ReadLine();
         
            if (input != "")
            {
             var words = input.Split(','); 
           
                ages = Convert.ToInt32(words[1]);
               
               if(ages > highestAge) 
               {
                highestAge = ages;
               }
             } 
           
              else
              {
                break;
                  
                }
                 Console.WriteLine("Age of the oldest is : " + highestAge);
               
                    
               
        }       
             
                 
            
       
     }
  }
}



