int urunFiyat = 1000;
float kdvOrani = 1.18f;   //float veri tipinde sayının yanına f ile belirtmek zorundayız!!!
int urunAdet = 5;

float toplam = (urunFiyat * urunAdet) * kdvOrani;

Console.WriteLine("Ürün toplam fiyatı : " + toplam);



// Veri Tipi Dönüşümü


Console.Write("1.sayı :");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.sayı : ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

var toplamm = sayi1 + sayi2;

Console.WriteLine("Toplam :" + toplamm);

int a = 10;
long b = a;

long d = 20;
int e = (int)d; // Bu gibi durumlarda büyükten küçüğe dönüşüm yaparsak onu belirtmemiz gerliyor çünkü orada bir veri kaybı olacak

double h = 10.6;
int i = (int)h; // Bu gibi durumlarda büyükten küçüğe dönüşüm yaparsak onu belirtmemiz gerliyor çünkü orada bir veri kaybı olacak


//Nullable Types

int? maas = null;   //int değeri null olamaz fakat ? işareti koyarak null değerini aldırabiliriz
Console.WriteLine(maas.HasValue); //HasValue herhangi bir değer olup olmadığını kontrol etmemize olanak sağlar
Console.WriteLine(maas.GetValueOrDefault()); //Maaş varsa getir yoksa da değeri 0 olarak getir demektir