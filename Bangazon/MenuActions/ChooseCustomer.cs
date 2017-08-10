using System;
using System.Collections.Generic;

namespace BangazonCLI
{
    public class ChooseCustomer
    {
        // Written By : Matt Augsburger
        // Method displays the Choose Customer Menu
        // Accepts Argument of an instance of CustomerManager
        // Lists Customers in the database
        // Sets selected Customer to _currentCustomer
         public static void ChooseCustomerMenu(CustomerManager cm, dbUtilities db)
        {
            var custList = cm.GetCustomerList();
            Dictionary<int, Customer> custDictionary = new Dictionary<int, Customer>();
            Console.Clear();
            int counter = 1;
            Console.WriteLine("Select customer");
            foreach(Customer c in custList)
            {
                custDictionary.Add(counter, c);
                Console.WriteLine($"{counter}. {c.firstName} {c.lastName}");
                counter++;

            }
            Console.WriteLine(">");
            var choice = Console.ReadKey();
            string keyPressed = choice.KeyChar.ToString();
            NoEmptyAnswers.notAOne(keyPressed, "Please select a customer");
            int choiceInt;
            int.TryParse(keyPressed, out choiceInt);


            foreach(KeyValuePair<int, Customer> kvp in custDictionary)
            {
                if(choiceInt == kvp.Key)
                {
                    Console.WriteLine($"You selected {kvp.Value.firstName} {kvp.Value.lastName} as the current customer");
                    CustomerManager.currentCustomer = kvp.Value;
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadKey();
                }
            }

        }
    }
}