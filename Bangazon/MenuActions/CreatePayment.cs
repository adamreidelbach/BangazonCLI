using System;

namespace BangazonCLI
{
    // Written by: Eliza Meeks
    // Menu action to create a payment type.
    public class CreatePayment
    {
        // Method to create the menu and allow the user to input a payment type name and account number.
        public static void CreatePaymentMenu(PaymentTypeManager ptm)
        {
            
            Console.Clear();
            //Prompt and then takes payment type
            Console.WriteLine($"Enter payment type (e.g. AmEx, Visa, Checking)");
            Console.WriteLine($">");
            string paymentName = Console.ReadLine();

            int accountNumber = 0;
            //Prompts and then takes account number
            do{
                try{
                    Console.WriteLine($"Enter Account Number");
                    Console.WriteLine($">");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    // int.TryParse(Console.ReadLine(), out accountNumber);
                }catch{
                    Console.WriteLine($"Enter Account Number");
                    Console.WriteLine($">");
                    Int32.TryParse(Console.ReadLine(), out accountNumber);
                }
                

            } while (accountNumber == 0);

            // int accountNumber = int.Parse(Console.ReadLine());
            PaymentType newPaymentType = new PaymentType() { accountNumber=accountNumber, name=paymentName };
            ptm.AddNewPaymentType(newPaymentType);
            Console.WriteLine("Payment type added. Press any key to continue.");
            Console.ReadLine();


        }
    }
}