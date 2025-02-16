namespace _02_Geriye_DegerDonduren
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sayi = Hesapla();
            //Console.WriteLine(sayi);
            //Console.WriteLine(Hesapla());

            //Console.WriteLine(CevapVeren("Naber"));
            MethodCagir();

        }
        static int Hesapla()
        { 
            int sayi1 = 20;
            int sayi2 = 20;
            int toplam = sayi1 + sayi2;
            return toplam;//Gelen değer işlem yapıldıktan sonra geriye döndereceği değişken yapısını return ile gösteririz.
        }
        static string CevapVeren(string metin)
        {
            Console.WriteLine(metin);
            metin="İyim";
            return metin;// Gelen değer güncellendikten sonra geriye farklı bir şekilde çıkış yapıyor  Return ile geriye tek bir değer dönderilir.
        }
        static void MethodCagir()
        {
            Console.WriteLine("Değer giriniz");
            double deger = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Değer giriniz");
            double deger2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Donder(deger, deger2)); 
        }
        static double Donder(double s1, double s2)
        {
            return s1*s2;
        }
    }
}
