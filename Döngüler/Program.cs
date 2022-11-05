int faktoriyel = 1;
Console.Write("Hesaplamak İstediğiniz Sayıyı Giriniz : ");
int sayi = Convert.ToInt16(Console.ReadLine());
int i;
for (i = 1; i <= sayi; i++)
{
    faktoriyel *= i;
}
Console.WriteLine("Girilen değer :"+sayi +"!");
Console.WriteLine("Sonuç : " + faktoriyel);









