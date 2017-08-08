﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;


namespace BangazonCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seed the database if none exists
            dbUtilities db = new dbUtilities("BANGAZONCLI_DB");
            CustomerManager cm = new CustomerManager(db);
            PaymentTypeManager ptm = new PaymentTypeManager(db);
            db.CheckCustomer();

            MainMenu menu = new MainMenu();

            int choice;

            do
            {
                // Show the Main Menu
                choice = menu.ShowMainMenu();

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        CreatePayment.CreatePaymentMenu(ptm);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                }

            } while(choice != 12);
        }
    }
}
