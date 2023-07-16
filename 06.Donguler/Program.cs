namespace _06.Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> names = new();
            names.Add("Taner");
            names.Add("Tugay");
            names.Add("Tahir");
            names.Add("Toprak");
            names.Add("Türkan");
            names.Add("Seval");


            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[5]);


            // for, foreach


            //for(int x= 0; x < names.Count(); x++)
            //{
            //    Console.WriteLine(names[x]);
            //}

            //foreach (var x in names)
            //{
            //    Console.WriteLine(x);
            //}

            //oop içerisinde tip belirtmek zorunda olduğun için liste belirtilen tipte olmak sorunda
            //json formatı kullanıyor olsaydın listede farklı tipler olabilirdi.

            int x = 0;
            while (names.Count()>0) //sonsuz döngü oluşturur.
            {
                x++;
                if (x == 5) break;
                Console.WriteLine("Çalışıyo!");
            }
        }
    }
}