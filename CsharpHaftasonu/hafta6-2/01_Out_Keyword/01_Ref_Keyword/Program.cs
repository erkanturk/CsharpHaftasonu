namespace _01_Ref_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 10;
            //Console.WriteLine(sayi);
            //Test(ref sayi);
            //Console.WriteLine(sayi);
            int sayi= 11;
            double sayi1 = 111;
            double sayi2 = 112;
            double sayi3 = 11;
            Guncelle(ref sayi);
            UrunFiyatKontrol(ref sayi1, ref sayi2, ref sayi3);
        }
        static void Test(ref int sayi)
        {
            //Console.WriteLine(sayi);
            //sayi=100;
            //Console.WriteLine(sayi);
        }
        static void Guncelle(ref int sayi)
        {
            int a = sayi;
            Console.WriteLine("Gelen sayı: {0}", a);
            sayi=110;
            int a2 = sayi;
            Console.WriteLine("Güncellenen sayı değeri:{0}", a2);
        }
        static void UrunFiyatKontrol(ref double f, ref double f2, ref double f3)
        {
            Console.WriteLine("Eski fiyat"+f);
            f=f+(f*0.10);
            Console.WriteLine("Eski fiyat"+f2);
            f2=f2+(f2*0.20);
            Console.WriteLine("Eski fiyat"+f3);
            f3=f3+(f3*0.30);

            Console.WriteLine("güncel fiyatlar."+" "+f +" "+ f2 +" "+f3 );
        }
    }
}
