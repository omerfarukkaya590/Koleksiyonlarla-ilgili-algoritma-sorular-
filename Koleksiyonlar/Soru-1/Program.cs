using System.Collections;
using System;

// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
// (ArrayList sınıfını kullanara yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

ArrayList liste1= new ArrayList(); 
ArrayList liste2= new ArrayList(); 
System.Console.WriteLine("-----------HOŞGELDİNİZ----------------");
System.Console.WriteLine("Lütfen, 20 adet sayı giriniz.");
int i=1;
while (i<21)
{
   try
   {
       int a= Int32.Parse(Console.ReadLine());
   
   
   
     int control=0;
     int c=2;
        while (c<a)
        {
           if (a % c == 0)
      control++;

   c++;
        }

if (control != 0)
{
   liste1.Add(a);
}
else if(a==1)
{
   liste1.Add(a);
}
else
{
   liste2.Add(a);


}
   i++;
}  catch 
   {
      System.Console.WriteLine("numerik olmayan sayı girişi.");
      throw;
   }
}
liste1.Sort();
liste2.Sort();
liste1.Reverse();
liste2.Reverse();


System.Console.WriteLine("---------asal olmayan sayılar----------------");
foreach (var item in liste1)
{
   System.Console.WriteLine(item);

}
System.Console.WriteLine("---------asal sayılar----------------");

foreach (var item2 in liste2)
{
   System.Console.WriteLine(item2);

}
System.Console.WriteLine("------------asal olmayan eleman sayısı-----------");
int n=liste1.Count;
System.Console.WriteLine(n);
System.Console.WriteLine("------------asal eleman sayısı-----------");
int q=liste2.Count;
System.Console.WriteLine(q);


System.Console.WriteLine("------------asal olmayan ortalama-----------");


int toplam=0;
for (int ç = 0; ç < liste1.Count; ç++)
{
   toplam +=(int)liste1[ç];
   
}
System.Console.WriteLine(toplam/n);

System.Console.WriteLine("------------asal ortalama-----------");


int toplam2=0;
for (int T = 0; T < liste2.Count; T++)
{
   toplam2 +=(int)liste2[T];
   
}
System.Console.WriteLine(toplam2/q);


