using System.Runtime.InteropServices;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instance of the class -> örnekleme
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diayrbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };
            
            //type-safe -> Tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine("------------Methods--------------");
            //class ->reusability
            //encapsulation
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Armut", 25, "Yeşil armut",5);
            cartManager.Add2("Elma", 15, "amasya elması",6);
            cartManager.Add2("Karpuz", 40, "Sulu karpuz",16);
        }
    }
}

//Don't repeat yourself  -DRY
//Clean code - Best Practice
//Class -> Pascal case kullanılır