namespace _03_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi>0)
            {
                Console.WriteLine("Sayı sıfırdan büyüktür");
                if (sayi>=100)
                {
                    Console.WriteLine("Sayı 100 yada daha büyük bir sayıdır.");
                }
            }
            else if (sayi<0)
            {
                Console.WriteLine("Sayı küçüktür sıfırdan");
            }
           else
            {
                Console.WriteLine("Sayı eşittir sıfıra");
            }
        }
    }
}
