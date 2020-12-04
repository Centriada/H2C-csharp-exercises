using System;
using System.Collections.Generic;

namespace exercise_66
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
           

      while (true)
      { 
        string input = Console.ReadLine();
                                                             
        if (input == "")
        {
             int index = 0;
            if (index < list.Count) 
             {
                            index = index +1;
                   Console.WriteLine(list[index - 1]); 
               
             }  
          break;
              
        list.Add(input);
        
            
                       
         }  
        
      }      
      
       
           
       
        
    }
  }
}
