using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
       

      Account heikkisAccount = new Account("Heikki's account", 100.00);
      Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);
            Console.WriteLine("Intial state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);
            heikkisAccount.Deposit(20);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance);
    }
  }
}



