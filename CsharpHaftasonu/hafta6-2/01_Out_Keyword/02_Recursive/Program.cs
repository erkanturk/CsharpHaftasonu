namespace _02_Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 1;
            int s2 = 2;
            Console.WriteLine("Çoklu form içinb 1 e basınız tekli form için 2 ye basınız");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (s==sayi)
            {
                int s3 = 0;
                Console.WriteLine("Kaç adet olsun");
                int s4 = Convert.ToInt32(Console.ReadLine());
                CokluForm(s4,s3);
            }
            else if (s2==sayi)
            {
                Form();
            }
            else
            {
                Console.WriteLine("Yanlış veya hatalı işlem ");
            }
        }
        static void Form()
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            string yas = Console.ReadLine();
            Console.WriteLine($"Ad: {ad}\nsoyad: {soyad}\nyaş: {yas} ");
        }
        static void CokluForm(int s, int s2)
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            string yas = Console.ReadLine();
            if (s>s2)
            {
                CokluForm(s-1, s2);
            }
            Console.WriteLine($"Ad: {ad}\nsoyad: {soyad}\nyaş: {yas} ");
        }

    }
}
