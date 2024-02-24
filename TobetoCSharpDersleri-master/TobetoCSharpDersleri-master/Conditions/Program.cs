namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if-else block
            var number = 13;
            if (number == 10)
                Console.WriteLine("Number is 10");
            else if (number == 20)
                Console.WriteLine("Number is 20");
            else
                Console.WriteLine("Number is not 10");


            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            #endregion

            #region switch block
            int sayi = 10;
            switch (sayi)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 20 or 10");
                    break;
            }
            #endregion

            #region many if-else block
            //and ve or operatörleri kullanımı
            if (sayi >= 10 && sayi <= 100)
                Console.WriteLine("number is between 10-100");
            else if (sayi > 100 && sayi <= 200)
                Console.WriteLine("number is between 100-200");
            else if (sayi > 200 || sayi < 0)
                Console.WriteLine("Number is  less then 0 and greater then 200");
            #endregion

            #region Nested if block
            if (number < 100)
            {
                if (number <20)
                {

                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}