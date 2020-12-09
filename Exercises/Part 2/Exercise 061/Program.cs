using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
     {  
       PrintSpaces(1);
            Console.WriteLine("");
            PrintRightTriangle(4);
            Console.WriteLine("");
            ChristmasTree(4);
            PrintStars();
    }

        public static void PrintSpaces(int number)
        {
          
            int i = 0;
         while (i < number) 
          {
             Console.Write("");
             i++;
           
          }
       
         } 

        public static void PrintStars(int number)
    {
              int i = 0;
         while (i < number) 
          {
             Console.Write("*");
             i++;
           
          }
       
    } */

    

     public static void PrintRightTriangle(int size)
    {
         
           for (int i = 1; i <= size; i++)
            {
              for (int j = i; j <= size; j++)
                {
                Console.Write("*");
                }
              Console.WriteLine();
            }
     }


    public static void ChristmasTree(int height)
    {
         for (int i = 0; i <= height; i++)
         {
              for (int j = i; j <= height - 1; j++)
               {
                    Console.Write(" ");
              }
              for (int k = 0; k <= i; k++)
               {
                Console.Write("* ");
               }   
              Console.WriteLine();
          }   
            
           for (int i = 0; i < 2; i++)
                {
                
                for (int j = 0; j < 2; j++)
              {
                 Console.Write(" ");
                }
                 Console.WriteLine("* *");
           }
           Console.WriteLine();

     }    
  }
}
