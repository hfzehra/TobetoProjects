namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            // RAM'de yer kaplamalarına göre :
            // long > int > short > byte
            int number1 = 2147483647;
            long number2 = 21474836472147483;
            short number3 = 32767;
            byte number4 = 255;

            //int -> double 
            double number5 = 10.5;
            //long -> decimal
            decimal number6 = 128.5m;

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);

            //bool -> şart manasına gelir
            bool condation=false;
            Console.WriteLine("bool değeri : {0} ", condation);

            //char -> karakter almamızı sağlar 
            char char1 = 'a';
            Console.WriteLine("karakter : {0} ", char1);
            Console.WriteLine("karakter : {0} ", (int)char1);
            Console.WriteLine(Days.Saturday);

            //Enum kullanımı
            Console.WriteLine((int)Days.Saturday);
            Console.ReadLine();

            //var kullanımı
            var number7 = 7;
            number7 = 'A';
            Console.WriteLine(number7);
        }

    }

    //Magic String -> teker teker stringle kontrol etme
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}