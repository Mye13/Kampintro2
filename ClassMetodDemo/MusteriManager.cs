using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler Listeleniyor ;");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.musteriTc + " " + musteri.musteriPara);
            }
            Console.WriteLine("--------------");
        }


        public void Ekle(string musteriAdi, string musteriSoyadi, int musteriTc, int musteriPara)
        {
            Console.WriteLine("Yeni Müşteriniz Var!!!" + " " + "-->" + " " + musteriAdi + " " + musteriSoyadi + " " + musteriTc + " " + musteriPara);
            Console.WriteLine("--------------");
        }



        public void Cıkar(string musteriAdi, string musteriSoyadi)
        {
            Console.WriteLine(musteriAdi + " " + musteriSoyadi + " " + "Bankanızdan Ayrıldı!");
            Console.WriteLine("--------------");

        }
    }
}
