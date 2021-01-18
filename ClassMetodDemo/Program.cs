using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Toyota";
            musteri1.musteriSoyadi = "Supra";
            musteri1.musteriTc = 1996;
            musteri1.musteriPara = 1500000;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Honda";
            musteri2.musteriSoyadi = "Nsx";
            musteri2.musteriTc = 1995;
            musteri2.musteriPara = 1400000;

            Musteri musteri3 = new Musteri();
            musteri3.musteriAdi = "Nissan";
            musteri3.musteriSoyadi = "SkylaneGtr";
            musteri3.musteriTc = 1997;
            musteri3.musteriPara = 1450000;

            Musteri musteri4 = new Musteri();
            musteri4.musteriAdi = "Mitsubishi";
            musteri4.musteriSoyadi = "LancerEvo";
            musteri4.musteriTc = 1997;
            musteri4.musteriPara = 1348000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(musteriler);

            musteriManager.Ekle("Subaru", "Wrx", 1995, 1250000);

            musteriManager.Cıkar("Toyota", "Supra");


        }      
    }
}
