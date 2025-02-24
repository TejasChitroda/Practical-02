using System;

namespace CSharpTutorials
{ 
    // I used internal access modifier because I might not be used in other assembly
    internal class Customer_Account
    {
        
        private static string bank_name;   // Used static because there is no need to initialize variable at every instance of class
        private long customer_accountNo;  //  Long data type because ID may have very large number and used Private access modifier so it is only accessible in same class
        private string customer_name;     // customer_name is String data type and Private access modifier so it is only accessible in same class

        // Parameteried Constructor to initializ variable 
        public Customer_Account(long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo;
            this.customer_name = customer_name;
        }

        // Method to print account details
        // used void return type because this Method is not returning any data
        // Used private access modifier because we can only use this method in same class
        void printInfo()
        {
            Console.WriteLine("Customer Details\n");
            Console.WriteLine($"\tCustomer Name: {customer_name}\n\tCustomer's Bank Name: {bank_name}\n\tCustomer's Account No: {customer_accountNo}");
        }

        public static void Main(string[] args)
        {
            // Assigning value to static variable
            Customer_Account.bank_name = "ABC Bank";

            // Creating an instance of Customer_Account Class
            Customer_Account ca = new Customer_Account(123456789, "Tejas Chitroda");

            // Printing account details
            ca.printInfo();
        }
    }
}
