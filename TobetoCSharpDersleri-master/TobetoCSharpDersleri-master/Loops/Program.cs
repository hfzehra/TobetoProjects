namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR DÖNGÜSÜ
            //ForLoop();

            //WHILE DÖNGÜSÜ
            //WhileLoop();

            //DO-WHILE DÖNGÜSÜ
            //DoWhileLoop();

            //FOREACH DÖNGÜSÜ -> Datayı gezmek için sıklıkla kullanırız
            string[] students = new string[3] { "Zehra", "Ceren", "Serdar" };
            foreach (var item in students)
            {
                //Yanlış bir yazımdır. Bilgilere ekleyemeyiz
                //item = "Ahmet";
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number > 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("FİNİSHED");
        }
    }
}