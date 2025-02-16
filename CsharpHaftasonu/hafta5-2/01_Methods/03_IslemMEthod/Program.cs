namespace _03_IslemMEthod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız
            //Indirim();

            // kullanıcıdan alınan ürün fiyatına kdv uygulayıp geriye dönderin ve ekrana yazdırın
            Console.WriteLine("Fiyat Giriniz:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            double kdvFiyat = KdvUygula(fiyat);
            Console.WriteLine($"Kdv uygulanmış fiyat: {kdvFiyat}");
        }
        //static void Indirim()
        //{
        //    Console.WriteLine("1.Urun Fiyatı");
        //    double fiyat1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("2.Urun Fiyatı");
        //    double fiyat2 = Convert.ToDouble(Console.ReadLine());
        //    if (fiyat1>=fiyat2)
        //    {
        //        fiyat1*=0.70;
        //    }
        //    else if (fiyat2>=fiyat1)
        //    {
        //        fiyat2*=0.70;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı işlem");
        //    }
        //    Console.WriteLine("Üçüncü üründe %50 indirim var ablam bak al istersen");
        //    string cevap = Console.ReadLine().ToUpper();
        //    if (cevap=="E")
        //    {
        //        Indirim3(fiyat1, fiyat2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hıı peki sen bilirsin.");
        //        Console.WriteLine("Toplan ödenecek tutar: {0}", (fiyat1+fiyat2));
        //    }


        //}
        //static void Indirim3(double f1, double f2)
        //{
        //    Console.WriteLine("3.Ürün Fiyatı");
        //    double f3 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine($"Ödeme: {f1+f2+(f3/2)}");
        //}
        static double KdvUygula(double f1)
        {
            f1=f1*1.25;
            return f1;
        }

    }
}
