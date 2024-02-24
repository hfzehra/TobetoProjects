using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HousingLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
