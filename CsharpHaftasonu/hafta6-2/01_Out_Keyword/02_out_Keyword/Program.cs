namespace _02_out_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f1, f2, f3;
            f1=200;
            f2=400;
            f3=1200;
            UrunFiyatGetir(out f1, out f2, out f3);
            Console.WriteLine($"1.Fiyat{f1}- 2.Fiyat{f2} -3.Fiyat{f3}");
        }
        static void UrunFiyatGetir(out double s, out double s2, out double s3)
        {
            s=220;
            s2=500;
            s3=900;
        }
    }
}
