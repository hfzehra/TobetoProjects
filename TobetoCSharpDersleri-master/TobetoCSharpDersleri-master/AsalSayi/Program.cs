namespace AsalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            if (IsPrimeNumber(number))
            {
                Console.WriteLine("Asal sayıdır");
            }
            else
            {
                Console.WriteLine("Asal Sayi değildir");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            //Kendisi ve bir hariç böleni olmayan sayıya asal sayı denir 
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}