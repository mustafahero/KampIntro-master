using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 20;
            urun1.Aciklama = "En iyi amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Pırasa";
            urun2.Fiyati = 12;
            urun2.Aciklama = "Bahçeden Pırasa";

            Urun urun3 = new Urun();
            urun3.Adi = "Lahana";
            urun3.Fiyati = 23;
            urun3.Aciklama = "Taze lahana";


            // veya Urun[] urunler = new Urun[] { urun1, urun2, urun3 }; yapılabilir
            Urun[] urunler = { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------Metotlar-----------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            




        }
    }
}
// Don't repeat yourself! - DRY