namespace odevCozum_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sistemin rastgele üretmiş olduğu sayıyı kullanıcının bulması için bir kod bloğu yazarak, eğer kullanıcının girdiği sayı üretilen sayıdan büyük ise kullanıcının büyük bir sayı girdiğini, 
            //küçük sayı girdiyse kullanıcının küçük sayı girdiğini uyarısını veriniz.
            //ve kullanıcnın bu 3 adımlı tahmin oyununda 5 hakkı olsun.
            //Rastgele üretilen sayı(10,100) arasında olsun.
            //try-catch do while

            //Kullanıcıdan alınacak ürün sayısına göre her bir ürünün fiyatını bir bir isteyip kullanıcıya fiyatlarınınn toplamlarını gösteriniz.
            //Try catch ve do while

            #region random ödevi

            //try
            //{
            //    Random random = new Random();
            //    int randomSayi = random.Next(10, 100);
            //    int hak = 1;
            //    do
            //    {
            //        //int randomSayi= random.Next(10, 100);
            //        Console.WriteLine("{0}. Hakkınız. Bir sayı giriniz", hak);
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(sayi);
            //        Console.WriteLine();
            //        if (sayi<randomSayi)
            //        {
            //            Console.WriteLine("Girilen sayı üretilen sayıdan Küçüktür"+ randomSayi);
            //            Console.WriteLine("*****");
            //            if (hak==5)
            //            {
            //                Console.WriteLine("Hakkınız Bitmiştir {0}", randomSayi);
            //                break;
            //            }
            //        }
            //        else if (sayi>randomSayi)
            //        {
            //            Console.WriteLine("Girdiğiniz sayı Üretilen sayıda Büyüktür"+randomSayi);
            //            Console.WriteLine("*****");
            //            if (hak==5)
            //            {
            //                Console.WriteLine("Hakkınız Bitmiştir {0}", randomSayi);
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Tebrikler Doğru tahmin "+sayi);
            //            Console.WriteLine("*****");
            //            break;
            //        }
            //        hak++;

            //    }
            //    while (true);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hatalı işlem "+ ex.Message);

            //}
            #endregion

            int urunSayisi = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Ürün Sayısı Giriniz");
                    urunSayisi=Convert.ToInt32(Console.ReadLine());
                    if (urunSayisi>0)
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Doğru ürün sayısı girininiz");
                }
            }
            double toplam = 0, sayac = 0;
            do
            {
                try
                {
                    Console.WriteLine(sayac +1 + ".Ürün fiyatını giriniz");
                    double fiyat = Convert.ToDouble(Console.ReadLine());
                    toplam+=fiyat;
                    sayac++;
                    urunSayisi--;
                }
                catch (Exception)
                {

                    Console.WriteLine("Dogru Fiyat giriniz");
                }
            }
            while (urunSayisi>0);
            Console.WriteLine("***************");
            Console.WriteLine("Girilen {0} adet ürünün toplam fiyatı: {1}",sayac,toplam);
        }
    }
}
