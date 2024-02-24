namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //referans type
            string[] students = new string[3] { "Zehra", "Elif", "Fatma" };

            //students[0] = "Zehra";
            //students[1] = "Elif";
            //students[2] = "Fatma";

            string[] students2 = {"Elif", "Fatma",  "Zehra" };

            //4.eleman olmadığı için hata verir.
            //students[3] = "Fatma";


            foreach (var item in students2)
            {
                Console.WriteLine(item);
            }

            //-------------------------------------------------------------------

            //ÇOK BOYUTLU DİZİ
            string[,] regions= new string[5, 3]
            {
                {"istanbul","izmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };
            
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                    Console.WriteLine(regions[i,j]);

                Console.WriteLine("************************");
            }

            Console.ReadLine();
        }
    }
}