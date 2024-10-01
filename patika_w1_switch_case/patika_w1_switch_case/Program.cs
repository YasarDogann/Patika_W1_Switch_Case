using System;

namespace SwitchCase
{
    class Program
    {
        //enum olarak meyveleri tanımladım
        enum Fruits
        {
            apple,
            pear,
            strawberry,
            banana,
            other
        }

        static void Main(string[] args)
        {/**
            // İF ELSE HALİ KULLANARAK YAPILMIŞ HALİ

            //meyvelerin fiyatlarını int olarak tutmak istedim.
            int apple = 2;
            int pear = 3;
            int strawberry = 2;
            int banana = 3;
            int other = 4;

            //kategori görünümünü yaptım
            Console.WriteLine("Mauro's Manavına Hoşgeldiniz...");
            Console.WriteLine("Elma : 2 TL");
            Console.WriteLine("Armut : 3 TL");
            Console.WriteLine("Çilek : 2 TL");
            Console.WriteLine("Muz : 3 TL");
            Console.WriteLine("Diğer Tüm Meyveler : 4 TL");
            Console.WriteLine("******************************");

            Console.Write("Hangi meyveyi almak istersiniz ? ");
            string choose = Console.ReadLine();
            choose = choose.ToLower(); //ToLower() fonksiyonun'u kullanarak kullanıcının büyük harfle yazmasına karşın küçülte işlemi yaptım


            if (choose == "elma")
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Adı: {choose} ve Fiyatı : {apple} TL");
            }
            else if (choose == "armut")
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Adı: {choose} ve Fiyatı : {pear} TL");
            }
            else if (choose == "çilek")
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Adı: {choose} ve Fiyatı : {strawberry}TL");
            }
            else if (choose == "muz")
            {
                Console.WriteLine($"Seçtiğiniz Meyvenin Adı: {choose} ve Fiyatı : {banana} TL");
            }
            else
            {
                Console.WriteLine($"Seçtiğiniz Meyve : {choose}'dir. Diğer Kategorisinde ve fiyatı : {other} TL'dir");
            }
            
            */

            // SWİTCH CASE YAPISI KULLANARAK YAPILMIŞ HALİ

            //kullanıcı meyve isimlerini İngilizce yazmasın diye türkçe meyve isimlerini enum karşılıklara eşleştirdim.
            Dictionary<string, Fruits> fruitsDictionary = new Dictionary<string, Fruits>()
            {
                { "elma", Fruits.apple },
                { "armut", Fruits.pear },
                { "çilek", Fruits.strawberry },
                { "muz", Fruits.banana },
                { "farklı meyve", Fruits.other },
            };

            Console.WriteLine("Mauro's Manavına Hoşgeldiniz...");
            Console.WriteLine("Elma : 2 TL");
            Console.WriteLine("Armut : 3 TL");
            Console.WriteLine("Çilek : 2 TL");
            Console.WriteLine("Muz : 3 TL");
            Console.WriteLine("Diğer Tüm Meyveler : 4 TL");
            Console.WriteLine("******************************");

            Console.Write("Hangi meyveyi almak istersiniz ? ");
            string choose = Console.ReadLine().ToLower(); //küçük harfe çevirdim.

           
            //kullanıcıdan gelen girdiyi Türkçe alıp Enum'a çeviriyoruz.
            if (fruitsDictionary.TryGetValue(choose, out Fruits fruit))
            {
                switch (fruit)
                {
                    case Fruits.apple:
                        Console.WriteLine($"Seçtiğiniz Meyve Elma ve fiyatı : 2 TL");
                        break;
                    case Fruits.pear:
                        Console.WriteLine($"Seçtiğiniz Meyve Armut ve fiyatı : 3 TL");
                        break;
                    case Fruits.strawberry:
                        Console.WriteLine($"Seçtiğiniz Meyve Çilek ve fiyatı : 2 TL");
                        break;
                    case Fruits.banana:
                        Console.WriteLine($"Seçtiğiniz Meyve Muz ve fiyatı : 2 TL");
                        break;
                    case Fruits.other:
                        Console.WriteLine($"Seçtiğiniz Meyvenin fiyatı : 4 TL");
                        break;
                    default:
                        Console.WriteLine("Geçersin Girdi");
                        break;
                }
            }
            Console.ReadKey();


        }

    }
}