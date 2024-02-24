namespace Class
{
    internal class Program
    {
        //isimlendirme kurallarına çok dikkat edilmeli
        static void Main(string[] args)
        {
            CustumerManager manager = new CustumerManager();
            manager.Add();
            manager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Zehra";
            customer.LastName = "Uysal";

            Customer customer2 = new Customer 
            {
                Id = 2, City="İstanbul", FirstName="Elif" , LastName="Demir"
            };
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }

}