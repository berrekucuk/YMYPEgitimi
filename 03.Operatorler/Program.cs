Console.WriteLine("Hello, World!");

//Operatörler
//= eşittir operatörü => değer ataması yapar
// == kontrol operatörü => a ve b  değerini kontrol eder

int a = 0;
int b = 1;

var c = (a == b);

// +,-,*,/

int r = ((5 * 2) + 5) - 0;

//+=   eşittirdensonraki değeri + işaretinden önceki değere ekler.
// -=  eşittirdensonraki değeri - işaretinden önceki değere çıkartır.

int z = 1;
z += 5;   // ====> z = z + 5 ;

// ++; kullanılan değişkenin akamını 1 artırır.
//--; kullanılan değişkenin akamını 1 azaltır.
int x = 1;
x++;
x--;

// + operatörü string değerlerde birleştirme işlemi yapar

string name = "Berre " +" "+" Küçük"; //Berre Küçük
string name2 = $"{name} 34 yasında bir egitmen" ; // ==> Berre Küçük 34 yaşında bir eğitmen 

//@ operatörü  '\ (ters bölü)' işretini yapmak için kullanılır. Ayrıca string kodunda ikinci bir string açmamıza müsade eder.

string url = @"http:\" ;

var result = name + 2; // Rakam + string birleştirme işlemi yapar ==> Berre Küçük2

// % => mod operatörü sayının verilen sayıya tam bölünüp bölünmediğini kontrol eder 0 veya küsürat çıktısı verir.

var r2 = (x % 2);


