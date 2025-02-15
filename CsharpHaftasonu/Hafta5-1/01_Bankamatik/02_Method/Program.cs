namespace _02_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islemler();
        }
        static void Topla(int s1, int s2)
        {
            Console.WriteLine(s1+s2);
        }
        static void Cikart(int s1, int s2)
        {
            Console.WriteLine(s1-s2);
        }
        static void Carp(int s1, int s2)
        {
            Console.WriteLine(s1*s2);
        }
        static void Bol(int s1, int s2)
        {
            Console.WriteLine(s1/s2);
        }
        static void Islemler()
        {
            Console.WriteLine("1. sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlem:");
            char islem = Convert.ToChar(Console.ReadLine());
            if (islem=='+')
            {
                Topla(sayi, sayi2);
            }
            else if (islem=='*')
            {
                Carp(sayi, sayi2);
            }
            else if (islem=='-')
            {
                Cikart(sayi, sayi2);
            }
            else if (islem=='/')
            {
                if (sayi2!=0)
                {
                    Bol(sayi, sayi2);
                }
                else
                {
                    Console.WriteLine("Sayı sıfıra bölünemez");
                }



            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }
        }

    }
}
