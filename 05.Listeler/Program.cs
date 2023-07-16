Console.WriteLine("Hello, World!");


// [] => listeleri temsil eder => array işareti
// string[] ames ={"asdas", "asdasd"};
//index numarası desem => 0'dan başlar
//string[] names = new string [3];
//names[0] = "Taner";
//names[1] = "Taner";
//names[2] = "Taner";

//list<string> names = new List<string>(){"asdas" , "asdasd"};

List<string> names = new(); //Örneğe dönüştürmek için new kelimesini kullanıyoruz. Örneğe dönüştürme işleminde yazılımda "instance"üretme denir.
//List<string> yapısında sayı belirtmemize gerek yok

names.Add("Taner"); //0
names.Add("Taner"); //1
names.Add("Taner"); //2
names.Add("Taner"); //3
names.Add("Taner"); //4
names.Add("Taner"); //5
names.Add("Taner"); //6
names.Add("Taner"); //7
names.Add("Taner"); //8
names.Add("Taner"); //9
names.Add("Taner"); //10
names.Add("Taner"); //11
names.Add("Taner"); //12

names[12] = "Ahmet";

Console.WriteLine(names[12]);


//class User
//{
// public string Name;
//}

//var user1 = new User();
//var user2 = new User();
//var user3 = new User();

//List<User> users = new List<User>();
//List<User> users = new ();

