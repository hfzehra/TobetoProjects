namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zehra Uysal
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerId = "12345";
            customer1.Name = "Zehra";
            customer1.SurName = "Uysal";
            customer1.TcNo = "123254121";

            //Kodlama.io
            CoorparateCustomer customer2 = new CoorparateCustomer(); 
            customer2.Id = 2;
            customer2.CustomerId = "12346";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "100123456";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorparateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}