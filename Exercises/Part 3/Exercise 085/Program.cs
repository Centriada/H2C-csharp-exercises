using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
            string userdata1 = ("alex, sunshine");
            string userdata2 = ("emma, haskell");
           
           String userinfo =  Console.ReadLine();
            string[] pieces = userinfo.Split(",");
            Console.WriteLine("Name: " + pieces[0] + ",  password: " + pieces[1]);
            bool found = false;
         
            if (userdata1 == userinfo && userdata2 == userinfo)
             { 
            Console.WriteLine("You have successfully logged in!");
                 found = true;
                
               }
            if (found);
                {
            Console.WriteLine("You have successfully logged in!"); 
                        
                }
               if(!found);
                    
                    {
                Console.WriteLine("Incorrect username or password!");
                       
                }
               
               
           

	}
  }
}

