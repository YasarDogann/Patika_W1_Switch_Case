# Patika Week1 Switch-Case - Enum ile Manav Alıştırma Uygulaması
Merhaba,
Bu proje C# ile Switch-Case ve Enum kullanarak alıştırma için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- `swith case` yapısını anlamak
- Klavyeden alınan meyvenin ismini ve fiyatını önce `if else` daha sonra `switch case` karar yapısını kullanarak karşılaştırdım.
- İç içe `if else / switch case` yapısı kullanıldı.

## 🚀 Kod
```csharp
using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            string number = Console.ReadLine();
            int result = 0;

            //konsoldan alınan number tam sayıya dönüştürülür başarılı olursa result içine atanır.
            //eğer dönüşüm başarısız olursa result default değer atanacak.
            int.TryParse(number, out result);

            if (result > 10) //sayının 10'dan büyük olma durumu True ise Bloğa girecek ve diğer koşullar değerlendirilecek
            {
                if (result % 2 == 0) // 10'dan büyük sayının çift olma durumu sorgulanıyor. True ise bloğa girecek
                {
                    Console.WriteLine($"Girilen Sayı 10'dan büyük ve Çift Bir Sayıdır: {result}");
                }
                else
                {
                    Console.WriteLine($"Girilen Sayı 10'dan Büyük Tek bir Sayıdır: {result}");
                }
            }
            else if (result < 10) //sayının 10'dan Küçük olma durumu True ise Bloğa girecek ve diğer koşullar değerlendirilecek
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"Girilen Sayı 10'dan Küçük Çift Bir Sayıdır: {result}");
                }
                else
                {
                    Console.WriteLine($"Girilen Sayı 10'dan Küçük Tek bir Sayıdır: {result}");
                }
            }
            else //sayının 10'a eşittir.
            {
                Console.WriteLine("Sayı 10'a Eşittir.");
            }

            Console.ReadKey();
        }
    }
}
