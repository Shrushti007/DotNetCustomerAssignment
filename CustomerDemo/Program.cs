using System.Collections;
using CustomerDetails;


public class Program
{
    static void Main(string[] args)
    {
        CustomerOperation();
    }
    private static void CustomerOperation()
    {
        Console.WriteLine("Hello, World!");
        CustomerOperation customerOperation = new CustomerOperation();

        //Find by number
        customerOperation.PopulateEntries();
        Console.WriteLine("\nEnter the number to find the Name");
        int k = Convert.ToInt32(Console.ReadLine());
        string name = customerOperation.FindName(k);
        Console.WriteLine("\n" + name);
        Console.WriteLine("--------------------");

        //Add
        Customer cust = new Customer();
        Console.WriteLine("Enter CustomerId:");
        cust.CustomerId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        cust.CustomerName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter city:");
        cust.CustomerCity = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Mobile Number :");
        cust.MobileNo = Convert.ToInt32(Console.ReadLine());


        customerOperation.AddCustomer(cust);

        //GetAll
        List<Customer> customers = new List<Customer>();
        customers = customerOperation.GetCustomers();
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.CustomerId);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerCity);
            Console.WriteLine(customer.MobileNo);
            Console.WriteLine("----------------------");
        }

        //Array
        CustomerArray customerArray = new CustomerArray();
        ArrayList list = customerArray.GetTheArrayList();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        



    }




}