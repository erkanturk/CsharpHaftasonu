namespace _01_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcıya kaç personel olduğunu sorunuz verilen cevaba göre array boyutlanacak ve diziye personelin adını ekleyecek.
            //Console.WriteLine("Personel Sayınız:");
            //int personelSayi = Convert.ToInt32(Console.ReadLine());
            //string[] personels = new string[personelSayi];

            //for (int i = 0; i < personels.Length; i++)
            //{
            //    Console.WriteLine("{0}.Personel Adı:",i+1);
            //    string ad = Console.ReadLine();
            //    personels[i]=ad;
            //}
            //foreach (string personel in personels)
            //{
            //    Console.WriteLine(personel);
            //}

            #endregion

            //object[] obje = { "Erkan", 'A', 20.5, 20, true, false, DateTime.Now };//object her tipi barındıran bir yapıdır.

            //foreach (var item in obje)
            //{
            //    Console.WriteLine(item);
            //}
            // İçinde sayılar olan bir array olacak ve bu array yapısının içinde 20 adet sayı olacak bu sayılardan çift ve tek olanları ayrı ayrı toplayıp  ekrana yazdırınız.

            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 22, 33, 44, 55, 66, 77, 88, 99, 110, 115 };
            //int tekTopla = 0;
            //int ciftToplam = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i]%2==0)
            //    {
            //        ciftToplam+=sayilar[i];
            //    }
            //    else
            //    {
            //        tekTopla+=sayilar[i];
            //    }
            //}
            //Console.WriteLine("tek toplam: "+tekTopla);
            //Console.WriteLine("Çift Toplam: "+ciftToplam);

            //int[] tekler = new int[15];
            //int[] ciftler = new int[15];
            //for (int i = 0; i < 15; i++)
            //{
            //    Random random = new Random();
            //    int rSayi = random.Next(1, 250);
            //    if (rSayi%2==0)
            //    {
            //        ciftler[i] = rSayi;
            //    }
            //    else
            //    {
            //        tekler[i] = rSayi;

            //    }

            //}
            //Console.WriteLine("Çiftler");

            //foreach (var item in ciftler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*******");
            //Console.WriteLine("*******");
            //Console.WriteLine("Tekler");
            //foreach (var item in tekler)
            //{
            //    Console.WriteLine(item);
            //}

            Random r = new Random();
            int[] dizi = new int[r.Next(1, 200)];
            int i = 0;
            while (i<dizi.Length)
            {
                int sayi = r.Next(0, 2000);
                bool varMi = false;
                foreach (var item in dizi)
                {
                    if (item==sayi)
                    {
                        varMi=true;
                        break;
                    }
                }
                if (varMi==false)
                {
                    dizi[i]=sayi;
                    i++;
                }
            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**************");
            int enKucuk = dizi[0];
            int enBuyuk = dizi[0];

            foreach (var item in dizi)
            {
                if (item>enBuyuk)
                {
                    enBuyuk= item;
                }
                if (item<enKucuk)
                {
                    enKucuk= item;
                }
            }
            Console.WriteLine("En Büyük sayı: "+enBuyuk);
            Console.WriteLine("En Küçük sayı: "+enKucuk);



        }
    }
}
