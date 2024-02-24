namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names[4] = "İlker";
            //Console.WriteLine(names[4]);

            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            Console.WriteLine("-------------------------");
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}