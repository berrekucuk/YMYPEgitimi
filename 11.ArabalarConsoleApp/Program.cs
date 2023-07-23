namespace _11.ArabalarConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new();
            cars.Add(new Car() { Marka = "BMW", Model = 2023, Motorgucu = 5000 });
            cars.Add(new Car() { Marka = "Reno", Model = 2020, Motorgucu = 6000 });

            Console.WriteLine("Araba Yapay Zekasına Hoş Geldiniz!");
            Console.WriteLine("Size nasıl yardımcı olabilirim");
            Console.WriteLine("İşlem Listesi : ");
            Console.WriteLine("1-Araç Listesi : ");
            Console.WriteLine("2- Araç Sayısı : ");
            Console.WriteLine("3-Araç Ekle : ");
            Console.WriteLine("4-Araç Kirala : ");
            Console.WriteLine("5-Çıkış : ");

            while (true)
            {
                string cevap = Console.ReadLine();

                if (cevap.ToLower() == "Araç Listesi".ToLower())
                {
                    foreach (Car car in cars)
                    {
                        Console.WriteLine($". Marka: {car.Marka} - Model : {car.Model} - Motor Gücü: {car.Motorgucu}");
                    }
                }
                else if (cevap.ToLower() == "Araç Sayısı".ToLower())
                    Console.WriteLine($"Toplam araç sayısı : {cars.Count()}");

                else if (cevap.ToLower() == "Araç Ekle".ToLower())
                {
                    Console.WriteLine("Markayı Yazın: ");
                    string Marka = Console.ReadLine();
                tekrar1:;
                    Console.WriteLine("Modeli Yazın : ");
                    string ModelString = Console.ReadLine();
                    int model = 0;
                    if (!int.TryParse(ModelString, out model))
                    {
                        Console.WriteLine("Model bir sayı olmalıdır!");
                        goto tekrar1;
                    }
                tekrar2:;
                    Console.WriteLine("Motor Gücünü Yazın : ");
                    string MotorGucuString = Console.ReadLine();
                    int motorgucu = 0;
                    if (!int.TryParse(MotorGucuString, out motorgucu))
                    {
                        Console.WriteLine("Motor gücü bir sayı olmalıdır.");
                        goto tekrar2;
                    }
                    Car car = new();
                    car.Marka = Marka;
                    car.Model = model;
                    car.Motorgucu = motorgucu;

                    cars.Add(car);
                    Console.WriteLine("Arabanız başarıyla eklenmiştir!");
                }

                else if (cevap.ToLower() == "Çıkış".ToLower())
                {
                    Console.WriteLine("Ziyaretiniz için teşekkürler. Tekrar görüşmek üzere.");
                    break;
                }
                else if (cevap.ToLower() == "Listeyi Göster".ToLower())
                {
                    Console.WriteLine("İşlem Listesi : ");
                    Console.WriteLine("1-Araç Listesi : ");
                    Console.WriteLine("2- Araç Sayısı : ");
                    Console.WriteLine("3-Araç Ekle : ");
                    Console.WriteLine("4-Çıkış : ");
                }
                else if (cevap.ToLower() == "Araç Kirala".ToLower())
                {
                    for (int x = 0; x < cars.Count(); x++)
                    {
                        Console.WriteLine($"{x + 1}. {cars[x].Marka}");

                    }
                tekrar3:;
                    Console.WriteLine("Araç  seçimi yapın?");
                    Console.WriteLine("Araç numarası :");
                    string secilenAracString = Console.ReadLine();
                    int secilenArac = 0;
                    if (!int.TryParse(secilenAracString, out secilenArac))
                    {
                        Console.WriteLine("Sadece sayı ile araç seçebilirsiniz!");
                        goto tekrar3;
                    }
                    if (secilenArac > cars.Count())
                    {
                        Console.WriteLine("Seçtiğiniz araç filoda bulunmuyor.");
                        goto tekrar3;
                    }
                    Console.WriteLine("Kiralama tarihi :");
                    string kiralamaTarihi = Console.ReadLine();

                    Console.WriteLine("Kiralama saati : ");
                    string kiralamaSaati = Console.ReadLine();

                    Console.WriteLine("Teslim tarihi :");
                    string teslimTarihi = Console.ReadLine();

                    Console.WriteLine($"{cars[secilenArac - 1].Marka} marka aracını {kiralamaTarihi} {kiralamaSaati} tarihinde kiralamak üzere işlem yaptınız.");
                    Console.WriteLine($"Teslim tarihiniz: {teslimTarihi} {kiralamaSaati}.");
                    Console.WriteLine("Aracı zamanında teslim etmemeniz durumda cezai işlem uygulanacaktır."); 
                    Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz. (-_-)");
                }
            
                else
                {
                    Console.WriteLine("Ben henüz olgunlaşmamış bir yapay zekayım. \n Sadece Listedeki işlemleri yapabilirim!");
                }
                Console.WriteLine("Başka ne işlem yapmak istersiniz?");

                // ctrl+k+d yaparsan kodları düzgün sırasına yerleştirir.



            }
        }
    }
    public class Car
    {
        public string Marka;
        public int Model;
        public int Motorgucu;

    }
}