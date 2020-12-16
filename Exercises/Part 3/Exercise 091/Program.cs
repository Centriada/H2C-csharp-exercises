using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Please give name and age");
        int ages;
        int highestAge = 0;
        int  lowestAge = 0;
        string input;
        string eldestName = "";
        string youngestName = "";
        while (true)
        {
            input = Console.ReadLine();
        
               
          if (input != "")
          {
               var words = input.Split(',');
               ages = Convert.ToInt32(words[1]);
           
             if(ages > highestAge)
              {      highestAge = ages;
                 eldestName = words[0];
             }
          }
                else
                 {
                 Console.WriteLine("The name of the oldest is : " + eldestName);
                break;
                }
              
             

           
        }
    }
  }
}



