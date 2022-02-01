using AccountTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
   class AccountTest
   {
      static void Main()
      {
         //create two Account objects
         Account account1 = new Account("Jane Green", 50.00m);
         Account account2 = new Account("John Blue", -7.53m);

         //display intial value of name or each Account
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

         //prompt for than read input
         Console.Write("\nEnter deposit amount for account1 ");
         decimal depositAmount = decimal.Parse(Console.ReadLine());
         Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
         //Add to account1's balance

         //display balance
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{ account2.Name}'s balance {account2.Balance:C}");

         //prompt for then read input
         Console.Write("\nEnter depsoit amount for account2: ");
         depositAmount = decimal.Parse(Console.ReadLine());
         Console.WriteLine($"adding {depositAmount:C}"); // add to account2's balance

         //display balances
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");


      }
   }
}