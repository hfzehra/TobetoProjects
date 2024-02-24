namespace Interfaceses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //İnterfaceyi tek başına new yapamayız. 
            //IPerson person = new Customer();

            //İnterface de hangi veritabanına eklemek istiyorsak ona ekliyoruz
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2] 
            {
                new SqlServerCustomerDal() ,
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomeManager manager = new CustomeManager();
            manager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Zehra", LastName = "Uysal", Address = "Address" });
            Student student = new Student
            {
                Id = 1,
                FirstName = "Elif",
                LastName = "Demir",
                Departmant = "Cook"
            };
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Fatma",
                LastName = "Gür",
                Address = "İstanbul"
            };
            manager.Add(customer);
            manager.Add(student);
        }

        //Soyut
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        //Somut 
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }

        class Student:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}