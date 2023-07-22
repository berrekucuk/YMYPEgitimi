Console.WriteLine("Lütfen isminizi girin : ");
string name = Console.ReadLine();
Console.WriteLine("Sayı tahmini oyununa hoş geldiniz " + name);
Random rastgele = new Random();

int sayi = rastgele.Next(1, 10);
int tahmin = 0;
int deneme = 0;

while (sayi != tahmin)
{
    Console.WriteLine("Lütfen 1-10 arasında bir sayı tahmin ediniz.");
    string tahminEdilenSayi = Console.ReadLine();

    if (int.TryParse(tahminEdilenSayi, out tahmin) == false)
    {
        Console.WriteLine("Sadece rakam girilebilir!");
        continue;
    }

    if (tahmin > 10)
    {
        Console.WriteLine("Sadece 1-10 arası rakam yazabilirsiniz");
        continue;
    }

    Console.WriteLine("Tahmininiz : " + tahminEdilenSayi);

    if (sayi.ToString() == tahminEdilenSayi)
    {
        Console.WriteLine("Tebrikler! Tuttuğum sayıyı " + deneme + "  denemede buldunuz!");
        tahmin = sayi;
        continue;
    }


    Console.WriteLine("Tuttuğum sayıyı bilemediniz!!!");
    deneme++;


}