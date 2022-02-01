using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
   class Account
   {
      public string Name { get; set; } //auto-implemented property
      private decimal Balance; //instance variable

      // Account constructor that receives two parameters
      public Account(string accountName, decimal initialBalance)
      {
         Name = accountName;
         Balance = initialBalance; // Balance's set accessor validates
      }

      //Balance property with validation
      public decimal Balance
      {
         get
         {
            return Balance;
         }
         private set //can be used only within the class
         {
             //validate that the balance is greater that 0.0; if it's not,
             //instance variable balance keeps it's prior value 
            if (value > 0.0m) // m indicates that 0.0 is a decimal literal
            {
               Balance = value;
            } 
         
         }
      }

      //method that deposits (adds) only a valid amount to the balance
      public void Deposit(decimal depositAmount)
      {
         if (depositAmount > 0.0m)  // if the depositAmount is valid
         {
            Balance = Balance + depositAmount; // add it to the balance
         }
      }
   }
}