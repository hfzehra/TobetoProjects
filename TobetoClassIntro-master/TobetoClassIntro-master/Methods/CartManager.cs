using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        //naming covention -> doğru yazma teknikleri kullanılmalı 
        //Correnct usage
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations, Added to cart! : " + product.Name);
        }

        //Wronge use
        public void Add2(string product_name, double price, string description, int unitInStocks)
        {
            Console.WriteLine("Congratulations, Added to cart! : " + product_name);
        }
    }
}
