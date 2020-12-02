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

    //public static void PrintSpaces(int number)
    //{

    //}

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
          Console.ReadKey();
  }
}
