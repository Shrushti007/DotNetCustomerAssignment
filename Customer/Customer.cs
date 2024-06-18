namespace CustomerDetails;


public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerCity { get; set; }

    public int MobileNo { get; set; }

    public Customer()
    {
        
    }
    public Customer(int id,string name,string city)
    {
        this.CustomerId = id;
        this.CustomerName = name;
        this.CustomerCity = city;
    }

    public Customer(int id, string name, string city,int mobileno) : this(id, name, city)
    {
        this.MobileNo = mobileno;
    }
}
