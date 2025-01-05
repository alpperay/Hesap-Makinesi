using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    internal class HesapMakinesi
    {
        public void Topla()
        {
            int toplam;
            Console.WriteLine("Birinci sayıyı giriniz :");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz :");
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların Toplamı :" + toplam);
        }

        public void Cikar()
        {
            int cikarma;
            Console.WriteLine("Birinci sayıyı giriniz :");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz :");
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                cikarma = sayi1 - sayi2;
                Console.WriteLine("Sonuç :" + cikarma);
            }
            else if (sayi1 < sayi2)
            {
                cikarma = sayi1 - sayi2;
                Console.WriteLine("Sonuç :" + cikarma);
            }
            else
            {
                Console.WriteLine("Hatalı İşlem!");
            } 
        }

        public void Carp()
        {
            int carp;
            Console.WriteLine("Birinci sayıyı giriniz :");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz :");
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            carp = sayi1 * sayi2;
            Console.WriteLine("Sonuç :" + carp);
        }

        public void Bol()
        {
            float bol;
            Console.WriteLine("Bölünecek sayıyı Giriniz :");
            float sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Bölen sayıyı Giriniz :");
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                bol = sayi1 / sayi2;
                Console.WriteLine("Sayı :" + bol);
            }
            else if (sayi2 > sayi1)
            {
                bol = sayi1 / sayi2;
                Console.WriteLine("Sayı :" + bol);
            }
            else if (sayi2 == 0)
            {
                Console.WriteLine("0'a bölme hatası!");
            }
            else
            {
                Console.WriteLine("Hatalı İşlem");
            }
        }
    }
}
