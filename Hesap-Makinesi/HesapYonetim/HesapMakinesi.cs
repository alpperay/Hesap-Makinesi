public class HesapMakinesi {
    int sayi1,sayi2,toplam,cikar,carpma,asal;
    float bol;


    public void Topla()
    {
        Console.Write("Birinci Sayıyı Giriniz :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Birinci Sayıyı Giriniz :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        toplam = sayi1+sayi2;
        Console.WriteLine("Sonuç = "+ toplam);
    }

    public void Cıkar()
    {
        Console.Write("Birinci Sayıyı Giriniz :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Birinci Sayıyı Giriniz :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        if(sayi1>=sayi2)
        {
          cikar = sayi1-sayi2;
          Console.WriteLine("Sonuç = "+ cikar);
        }
        else{
            Console.WriteLine("Birinci sayı ikinci sayıdan küçük olamaz!");
        }
    }
       public void Carp()
    {
        Console.Write("Birinci Sayıyı Giriniz :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Birinci Sayıyı Giriniz :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        carpma = sayi1*sayi2;
        Console.WriteLine("Sonuç = "+ carpma);
    }

    public void Bol()
    {
        Console.Write("Bölünecek Sayıyı Giriniz =");
        float sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bölen Sayıyı Giriniz =");
        float sayi2 = Convert.ToInt32(Console.ReadLine());
        bol = sayi1/sayi2;
        if (sayi2 != 0)
        {
            bol = sayi1 / sayi2;
            Console.WriteLine("Sonuç = " + bol);
        }
        else
        {
            Console.WriteLine("0'a bölme hatası!");
        }
    }
}