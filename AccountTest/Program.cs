﻿using System;

namespace Bank
{
   class AccountTest
   {
      static void Main(string[] args)
      {
         //create an Account object and assign it to myAccount
         Account myAccount = new Account();

         //display myAccount's intial name (there isn't one yet)
         Console.WriteLine($"Initial name is: {myAccount.GetName()}");

         //prompt for and read the name. then put the name in the object
         Console.Write("Enter the name:"); //prompt
         string theName = Console.ReadLine(); //read the name
         myAccount.SetName(theName); // put theName in the myAccount object

         // display the name stored in the myAccount object
         Console.WriteLine($"myAccount's name is:{myAccount.GetName() }");
      }
   }
}