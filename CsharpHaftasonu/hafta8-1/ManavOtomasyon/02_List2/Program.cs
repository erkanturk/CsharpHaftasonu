namespace _02_List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();//örneklem //instance // nesne oluşturma

            kisi.Ad="Erkan";
            kisi.Soyad="Türk";
            kisi.Yas=30;

            Kisi kisi1 = new Kisi(); //
            kisi1.Ad="Hikmet";
            kisi1.Soyad="Yıldız";
            kisi1.Yas=31;

            //Console.WriteLine(kisi1.Ad);
            //List<string> list = new List<string>();
            //list.Add(kisi.Ad);
            //list.Add(kisi1.Ad);
            //list.Add(kisi1.Soyad);
            //list.Add(kisi.Soyad);

            //foreach (var ad in list)
            //{
            //    Console.WriteLine(ad);
            //}
            Console.WriteLine("***************");
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(kisi1);
            kisiler.Add(kisi);
            foreach (var kisi2 in kisiler)
            {
                Console.WriteLine($"{kisi2.Ad} {kisi2.Soyad} {kisi2.Yas}");
            }



        }
    }
    class Kisi
    {
        public string Ad;
        public string Soyad;
        public int Yas;
    }
    class Hayvan
    {
        public string Ad;
        public int Agirlik;
    }
}
