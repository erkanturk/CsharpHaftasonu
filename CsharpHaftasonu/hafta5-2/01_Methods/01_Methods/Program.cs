namespace _01_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yaz();
        }
        static void Yaz()
        {
            double sayi=0, sayi2 =0;
            DegerAl(sayi,sayi2);
        }
        static void DegerAl(double deger, double deger2)
        {
            Console.WriteLine("bir değer giriniz:");
            deger=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bir değer daha giriniz:");
            deger2 = Convert.ToDouble(Console.ReadLine());

            KdvUygula(deger, deger2);



        }
        static void KdvUygula(double d1, double d2)
        {
            d1=d1*1.20;
            d2=d2*1.20;

            Console.WriteLine("Kdv uygulanmış fiyat: {0}",d1);
            Console.WriteLine("Kdv uygulanmış fiyat2: {0}",d2);
        }

    }
}
