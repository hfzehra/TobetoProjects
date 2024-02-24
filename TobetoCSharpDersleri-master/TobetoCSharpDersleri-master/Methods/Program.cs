namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            int sonuc = Add2(15);
            int number1 = 20; int number2 = 30;

            //ref ile referans olarak gönderip alıyoruz. O yüzden Add3'de ki değer gelir.
            int result = Add3(ref number1, number2);
            Console.WriteLine(result);

            //number 1 olmazsa da olur.Set etme şartı vardır.
            int result2 = Add4(out number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(sonuc);

            //paramsla istediğimiz kadar parametre gönderebiliriz.
            Console.WriteLine(Add5(2,6,5,9,8,4,6,2,6));

            //Methodlarda overload(aşırı yükleme) işlemi
            Console.WriteLine(Multiple(2, 3));
            Console.WriteLine(Multiple(2, 3,4));
        }

        static void Add()
        {
            Console.WriteLine("Added !!");
        }

        //number2 verilmezse 26 değeri girilecek
        static int Add2(int number1, int number2 = 26)
        {
            return number1 + number2;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }


        static int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiple(int number1, int number2, int number3)
        {
            return number1 * number2 *number3;
        }


    }
}