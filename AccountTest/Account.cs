using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   class Account
   {
      private string name; // instance variable

      //property to get and set the name instance variable
      public string Name
      {
         get //returns the corresponding instance variables value
         {
            return name; //returns the value of name to the client code
         }
         set //assigns a new value to the corresponding instance variable 
         {
            name = value; //value is implicitly declared and initialized 
         }

      }
   }
}
