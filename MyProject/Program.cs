using System;
using System.Linq;

namespace Hesap_makinesi;

public static class Program
{
    public static void Main()
    {
        /** İlk Değişkenlerimiz Sayılar */

        int s1, alan, cevre, s2, s3, sonuc = 0;

        String input;

        /** yazımızı gönderdik */

        Console.Write("Merhaba, şimdiye kadarki en kapsamlı projeme hoş geldiniz. Basit bir hesap makinesinden farkı dakikalar alan hesaplamaları kolayca halledebilmemizdir. Kısmen bir otomasyon diyebiliriz. kodlarımızdan bahsedeyim. T toplama, Ç çıkartma, ÇA çarpma, K karesi, O 3 sayının ortlaması, D dikdörtgen. komut giriniz: ");


        input = Console.ReadLine();


        /** toplama i?lemi */
        if (input == "t")
        {
            Console.WriteLine("Toplama işlemini seçtiniz. ilk say?n?z? giriniz; ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayınızı giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            sonuc = (s1 + s2);
            Console.WriteLine("Sonuç: " + sonuc);
        }

        /** ç?kartma i?lemi */
        if (input == "ç")
        {
            Console.WriteLine("Ç?kartma i?lemini seçtiniz. ?lk say?n?z? giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("?kinci Say?n?z? giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            sonuc = (s1 - s2);
            Console.WriteLine("sonuç: " + sonuc);

        }

        /** çarpma i?lemi */
        if (input == "ça")
        {
            Console.WriteLine("Çarpma i?lemini seçtiniz. ilk say?y? giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("?kinci say?y? giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            sonuc = (s1 * s2);
            Console.WriteLine("Sonuç: " + sonuc);
        }

        /** Karesini alma */
        if (input == "k")
        {
            Console.WriteLine("Say?m?n karesini almay? seçtiniz. Karesini almak istedi?iniz say?y? giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            sonuc = (s1 * s1);
            Console.WriteLine("Sonuç: " + sonuc);
        }

        /** 3 say?n?n ortalamas? */
        if (input == "o")
        {
            Console.WriteLine("3 say?n?n ortalamas?n? bulmay? seçtiniz. ?lk say?n?z? girin: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("?kinci say?y? giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("üçüncü say?y? giriniz: ");
            s3 = Convert.ToInt32(Console.ReadLine());
            sonuc = (s1 + s2 + s3) / 3;
            Console.WriteLine("sonuç: " + sonuc);

        }
        if (input == "Zzz")
        {
            Console.WriteLine("A?k?m, seni her ?eyden çok seviyorum");
        }
        if (input == "ata")
        {
            Console.WriteLine("Benim naçiz bedenim elbet toprak olacakt?r. ancak Türkiye Cumhuriyeti ilelebet payidar kalacakt?r...");
        }

        /** Dikdörtgenin alan? ve çevresini bulma */
        if (input == "d")
        {
            Console.WriteLine("Dikdörtgeni seçtiniz. di?erlerinden farkl? olarak iki i?lemi birden yapaca??m. hadi ba?layal?m. siz bana dikdörtgenin uzun ve k?sa kenar?n? vereceksiniz ben de size hem alan?n? hem de çevresini verece?im. önce uzun kenar? alay?m :");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("K?sa kenar? alay?m: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            alan = (s1 * s2);
            cevre = ((s1 * 2) + (s2 * 2));
            Console.WriteLine("??lemler tamam. Dikdörtgenimizin alan? " + alan + "," + " dikdörtgenimizin çevresi " + cevre);
        }
    }
}