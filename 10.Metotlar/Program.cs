namespace _10.Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            int r = Metot(x,y);
            Console.WriteLine($"Sonuc :   {r}");
        }

        static void Metot() // geriye değer dönmeye metot
        {
            int sonuc = 5+3;
            Console.WriteLine($"Sonuç : {sonuc}");
        }
        static int Metot (int a,int b) //geriye değer dönen metot
        {
            int sonuc = a + b;
            return sonuc;
        }
    }
}