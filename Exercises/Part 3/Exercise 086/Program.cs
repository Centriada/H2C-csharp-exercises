using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    { 
            string userdata1 = "alex"+"sunshine";
            string userdata2 = "emma"+"haskell";
            Console.WriteLine("Enter username:");
            Console.WriteLine("Enter password;");
           String username =  Console.ReadLine();
            String password =  Console.ReadLine();

            if (userdata1 == username + password)
              { 
            Console.WriteLine("You have successfully logged in!");
               {
            if (userdata2 == username + password);
                {
            Console.WriteLine("You have successfully logged in!");  
                }
                if(!(userdata2 == username + password));
                    {
                Console.WriteLine("Incorrect username or password!");
                }
                 if(!(userdata1 == username + password));
                {
                 Console.WriteLine("Incorrect username or password!");
                }
            }

       }
    }
  }
}

