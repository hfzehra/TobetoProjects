namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer{FirstName="Zehra"},
                new Student{FirstName="Fatma"},
                new Person{FirstName="hatice"}
            };

            foreach (Person p in person)
            {
                Console.WriteLine(p.FirstName);
            }
            Console.ReadLine();
        }
    }
    //Personu kalıtım olarak aldık.
    //Yanlızca bir tane inheritance alabilirsiniz. İnterface gibi değildir
    //inheritance önce yazılır, interface sonra yazılır.
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    class Customer  :Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}