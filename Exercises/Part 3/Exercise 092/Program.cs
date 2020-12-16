using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
          int highest = 0;
          int longest = 0;
          string longestName = "";
      Console. WriteLine("Please enter name and birth year:");
      while (true)
      {
            string input = Console.ReadLine();
        
               
          if (input != "")
          {
               var details = input.Split(',');
                int birthYear = Convert.ToInt32(details[1]);
                int nameLength = details[0].Length;
                int age = 2020 - (birthYear);
            if (age > highest) highest = age;
            if (nameLength > longest)
            {
               longest = nameLength;
               longestName = details[0];
            }
           }
            
           else
            {
                     Console.WriteLine("The longest name is: " + longestName);
                    Console.WriteLine("The highest age is: " + highest); 
            break;
            }
           
          
      }
    }
  }
}



