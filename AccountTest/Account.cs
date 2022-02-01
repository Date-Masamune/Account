using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   class Account
   {
      public string Name { get; set; } // auto-implemented property

      //contructor sets the name property to parameter accountName's value
      public Account(string accountName) //constructor name is class name
      {
         Name = accountName;
      }
     

      
   }
}
