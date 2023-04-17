
using System;

namespace encapsulation 
{

    //class for Customer having their bank account
    public class Customer
    {
        //defining required fields for the customer 
        private string? customerFirstName ;
        private string? customerLastName ; 
        private string? customerAccountNumber ;

        //property having getters and setters method for the fields

        public string CustomerFirstName
        {
            get { return customerFirstName; }
            set { customerFirstName = value; }
        }
        public string CustomerLastName
        {
            get { return customerLastName; }
            set { customerLastName = value; }
        }

        public string CustomerAccountNumber
        {
            get { return customerAccountNumber; }
            set { customerAccountNumber = value; }

        }
        public void DisplayDetailsOfCustomer()
        {
            Console.WriteLine($"The Customer's First Name is {customerFirstName} ");
            Console.WriteLine($"The Customer's Last Name is {customerLastName} ");
            Console.WriteLine($"{customerFirstName}'s account number is {customerAccountNumber}");
        }
       

    }
namespace encapsulation{
 public class Bank 
    {
       /* static void Main(string[] args)
        {
            //creating object for the customer class

            Customer customer = new Customer();
            customer.CustomerFirstName = "vigneshwaran";
            customer.CustomerLastName = "R" ;
            customer.CustomerAccountNumber = "3462 7545 2345" ;
            customer.DisplayDetailsOfCustomer();
        }
        */

    }
}
   

}