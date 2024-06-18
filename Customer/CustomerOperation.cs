using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDetails;
namespace CustomerDetails
{
    public class CustomerOperation
    {
        List<Customer> customersList = new List<Customer>();
        public CustomerOperation()
        {
        customersList.Add(new Customer(1, "chetana", "Nashik"));
        customersList.Add(new Customer(2, "sanvi", "Thane"));
        customersList.Add(new Customer(3, "Adi", "Ghatkopar"));

        }


        public void AddCustomer(Customer customer)
        {
            Customer cust = new Customer();
            cust.CustomerId = customer.CustomerId;
            cust.CustomerName = customer.CustomerName;
            cust.CustomerCity = customer.CustomerCity;
            cust.MobileNo = customer.MobileNo;
            customersList.Add(cust);

        }
        //Find by number
        Hashtable ht = new Hashtable();
        public void PopulateEntries()
        {
            ht.Add(512354, "sai");
        }
        public string FindName(int key)
        {
            string name = (string)ht[key];
            return name;
        }

        //Get all Customer
        public List<Customer> GetCustomers()
        {
            return customersList;
        }

        


        




    }
}
