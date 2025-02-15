namespace _01_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* loops bir işi birden fazla yapmamızı sağlayan yapılardır kod kalabalıklığını azaltır ve verdiğimiz koşullara göre program ne kadar bu döngüde kalacağını belirtiriz birden fazla döngü çeşidi vardır her döngü (foreach harici) true olma durumunda çalışır.

            1-For başlangıç değeri koşul artış azalış
            2-while(koşul) true ise burada döngü yapılır
            3-do while c# a özgü bir döngü çeşididir ilk işlemi kontrol eder sonra durum true mu false mu bakar mutlaka 1 defa çalışır.

            
            */
            //int sayi = 1;
            //do
            //{
            //    Console.WriteLine($"{sayi}.sayıgı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    sayi++;
            //}
            //while (sayi<5);

            //int sayi = 10;
            //do
            //{
            //    Console.WriteLine(sayi);
            //    sayi--;
            //}
            //while (sayi>=1);
            #region Kullanıcıdan 0 girene kadar sayı girmesini isteyeceğiz ve kullanıcı 0 girdiğinde döngü sonlanacak kullanıcının girdiği tüm sayıların toplamını ekrana yazdıracak.
            //int toplam = 0;
            //int sayi;
            //do
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    sayi=Convert.ToInt32(Console.ReadLine());
            //    toplam+=sayi;

            //}
            //while (sayi!=0);//sadece true olduğu sürecede çalışır.
            //Console.WriteLine("Toplam:"+toplam);
            #endregion
            #region Döngü içinde break ve countinue kullanımı
            //int sayi = 0;
            //do
            //{
            //    sayi++;
            //    if (sayi==5 || sayi==6)
            //    {
            //        continue;
            //    }
            //    if (sayi==9)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(sayi);

            //}
            //while (sayi<=10);
            #endregion

            #region Tutulan değer
            //1 ila 100 arasında rasgele sistem tarafından üretilen sayıyı bulalım 
            Random random = new Random();
            int tutulanSayi = random.Next(1, 100);
            int girilenSayi = 0;
            do
            {
                Console.WriteLine("Sayı giriniz");
                girilenSayi=Convert.ToInt32(Console.ReadLine());
                if (girilenSayi>tutulanSayi)
                {
                    Console.WriteLine("Daha Küçük bir sayı giriniz");
                }
                else if (girilenSayi<tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz");
                }
                else
                {
                    Console.WriteLine("Tebrikler doğru tahmin");
                    break;
                }
            }
            while (true);
            #endregion
        }
    }
}
