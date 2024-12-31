HesapMakinesi hesap = new HesapMakinesi();
string secim;

do{
    Console.Clear();
    Console.WriteLine("Seçim Yapınız!");
    Console.WriteLine("Toplama İşlemi İçin --- T");
    Console.WriteLine("Çıkarma İşlemi İçin --- C");
    Console.WriteLine("Çarpma İşlemi İçin --- X");
    Console.WriteLine("Bölme İşlemi İçin --- B");
    Console.WriteLine("Çıkmak için --- E");
    secim = Console.ReadLine().ToUpper();
    Console.Clear();
    switch(secim)
    {
        case("T"):
        hesap.Topla();
        break;
        case("C"):
        hesap.Cıkar();
        break;
        case("X"):
        hesap.Carp();
        break;
        case("B"):
        hesap.Bol();
        break;
        case "E":
        Console.WriteLine("Çıkılıyor...");
        break;
    default:
        Console.WriteLine("Geçersiz seçenek! Lütfen tekrar deneyin.");
        break;
     }

    if (secim != "E")
    {
        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadKey();
    }
}
while(secim!="E");

