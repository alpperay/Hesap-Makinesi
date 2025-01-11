using Hesap_Makinesi;

HesapMakinesi hm = new HesapMakinesi();
string secim;
do
{
    Console.Clear();
    Console.WriteLine("Seçim Yapınız!");
    Console.WriteLine("Toplama İşlemi İçin ... 1");
    Console.WriteLine("Çıkarma İşlemi İçin ... 2");
    Console.WriteLine("Çarpma İşlemi İçin ... 3");
    Console.WriteLine("Bölme İşlemi İçin ... 4");
    Console.WriteLine("Çıkmak İçin ... 5");
    secim = Console.ReadLine();
    Console.Clear();

    switch (secim)
    {
        case "1":
            hm.Topla();
            break;
        case "2":
            hm.Cikar();
            break;
        case "3":
            hm.Carp();
            break;
        case "4":
            hm.Bol();
            break;
        case "5":
            Console.WriteLine("Çıkılıyor...");
            break;
        default:
            Console.WriteLine("Geçersiz seçenek! Lütfen tekrar deneyin.");
            break;
    }
    if (secim != "5")
    {
        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadKey();
    }
} while (secim != "5");
