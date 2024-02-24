namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Zehra";

            //Cümle uzunluğunu verir 
            var result = sentence.Length;
            Console.WriteLine(result);

            //cümleyi klonlayabiliriz
            var result2 = sentence.Clone();
            Console.WriteLine(result2);

            //bu cümle "a" ile bitiyor mu?
            bool result3 = sentence.EndsWith("a");
            Console.WriteLine(result3);

            //Cümle My name ile başlıyor mu ?
            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);

            //cümle içinde var mı yok mu ? 
            var result5 = sentence.IndexOf("name");
            var result6= sentence.LastIndexOf(" ");
            Console.WriteLine(result5);
            Console.WriteLine(result6);

            var result7 = sentence.Insert(0, "Hello ");

            //Metini kısımlara ayırmak için
            var result8= sentence.Substring(3, result6);
            Console.WriteLine(result8);

            // büyük küçük harf yapma
            var result9 = sentence.ToLower();
            var result10 = sentence.ToUpper();

            //Metinde karakter değiştirmek için kullanılır
            var result11 = sentence.Replace(" ", "-");
            Console.WriteLine(result11);

            //belli bir indexten sonrasını siler
            var result12= sentence.Remove(2,5);
            Console.WriteLine(result12);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            //İki stringi toplayabiliriz
            //string result = city + city2;
            //Console.WriteLine(result);

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}