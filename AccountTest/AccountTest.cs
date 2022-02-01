using System;

namespace Bank
{
   class AccountTest
   {
      static void Main(string[] args)
      {
         //create two Account objects
         Account account1 = new Account("Jane Green");
         Account account2 = new Account("John Blue");

         //display intial value of name or each Account
         Console.WriteLine($"account1 name is: {account1.Name}");
         Console.WriteLine($"account2 name is {account2.Name}");

      }
   }
}