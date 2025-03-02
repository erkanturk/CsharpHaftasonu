namespace _01_Out_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Outkeyword 
            //out keywordü ile dışarıda null olan bir değer var ise onun içini doldurabiliriz out keywordu ile  geriye değer döndüren method arasında şu fark vardır geriye değer döndüren method sadece bir değeri dönderirken out ile birden fazla değeri çıkış yapabiliriz.
            #region örnek 1
            //int sayi;
            //int sayi2;
            //Hesapla(20, out sayi, out sayi2);
            //Console.WriteLine(sayi+" "+sayi2);
            #endregion
            #region örnek 2
            //UrunFiyatGetir(out double sayi, out double sayi2);
            //Console.WriteLine($"Çarpımı: {sayi2}, {sayi}");
            #endregion

            //Test(out int ss,out int s2);
            //Console.WriteLine(ss+" "+s2);
            //Console.WriteLine(Test2(20,20));
        }
        //static void Test(out int s, out int s1)
        //{
        //    s=10;
        //    s1=20;
        //}
        //static int Test2(int sayi ,int s2)
        //{
        //    s2=20;
        //    sayi=10;
        //    return sayi;
        //}
        //static void UrunFiyatGetir(out double f1,out double f2)
        //{
        //    double f;
        //    Console.WriteLine("Birinci ürün fiyatını giriniz:");
        //    f=Convert.ToDouble(Console.ReadLine());
        //    f1=f+f;
        //    f2=f*1.20;

        //}
        //static void Hesapla(int s, out int kare, out int kup)
        //{

        //    kare=s*s;
        //    kup=s*s*s;
        //}
    }
}
