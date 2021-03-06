using System;


namespace BangazonCLI
{
// Written by: Matt Augsburger
    public class MainMenu
    {
        public int ShowMainMenu()
        {
             // Present the main menu
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ("*************************************************");
            Console.ResetColor();
            Console.WriteLine ("Welcome to Bangazon! Command Line Ordering System");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ("*************************************************");
            Console.ResetColor();
            Console.WriteLine ("1.  Create a customer account");
            Console.WriteLine ("2.  Choose active customer");
            Console.WriteLine ("3.  Create a payment option");
            Console.WriteLine ("4.  Add product to sell");
            Console.WriteLine ("5.  Add product to shopping cart");
            Console.WriteLine ("6.  Complete an order");
            Console.WriteLine ("7.  Remove customer product");
            Console.WriteLine ("8.  Update product information");
            Console.WriteLine ("9.  Show stale products");
            Console.WriteLine ("10. Show customer revenue report");
            Console.WriteLine ("11. Show overall product popularity");
            Console.WriteLine ("12. Leave Bangazon!");
			Console.ForegroundColor = ConsoleColor.Red;
            Console.Write ("> ");
            Console.ResetColor();

			// Read in the user's choice
			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);
            return choice;

        }
    }
}
