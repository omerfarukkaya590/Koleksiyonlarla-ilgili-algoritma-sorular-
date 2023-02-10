//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
// her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
//(Array sınıfını kullanarak yazınız.)


using System.Collections;

System.Console.WriteLine("--------------LÜTFEN 20 SAYI GİRİNİZ----------------");


ArrayList liste= new ArrayList();
int i=1;
while (i<21)
{
    int a= int.Parse(Console.ReadLine());
    liste.Add(a);
    i++;
}

liste.Sort();
System.Console.WriteLine("------------EN KÜÇÜK 3 SAYI-------------");

System.Console.WriteLine(liste[0]);
System.Console.WriteLine(liste[1]);
System.Console.WriteLine(liste[2]);

System.Console.WriteLine("------------EN BÜYÜK 3 SAYI-------------");

System.Console.WriteLine(liste[17]);
System.Console.WriteLine(liste[18]);
System.Console.WriteLine(liste[19]);
//ilk 3 sayı toplam
int toplam=0;
for (int q = 0; q < 3; q++)
{
    toplam += (int)liste[q];

}
//son 3 sayı toplam
int toplam2=0;
for (int t = 17; t < 20; t++)
{
    toplam2 +=(int)liste[t];
}
System.Console.WriteLine("----------------EN KÜÇÜK 3 SAYI ORT-------------");
System.Console.WriteLine(toplam/3);
System.Console.WriteLine("----------------EN BÜYÜK 3 SAYI ORT-------------");
System.Console.WriteLine(toplam2/3);
System.Console.WriteLine("----------------ORTALAMA TOPLAMLARI-------------");
System.Console.WriteLine(toplam/3 + toplam2/3);
