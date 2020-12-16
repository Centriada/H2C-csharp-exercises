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
       int  lowestAge = 0;
        Console.WriteLine("Please give name and age");
            string input;
        while (true)
        {
            input = Console.ReadLine();
          var words = input.Split(',');
               
          if (input != "")
            {
                    
           } for (int i = 0; i < input.Length; i++)
              {   
                     ages = Convert.ToInt32(words[1]);
               if (ages < lowestAge) lowestAge = ages;
               if(ages > highestAge) highestAge = ages;
             }    
              
               if (input =="")
                    {
                break;
                }
               Console.WriteLine("Age of the oldest is : " + highestAge);
        }       
             
                 
            
       
     }
  }
}



