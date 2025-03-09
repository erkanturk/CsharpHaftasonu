namespace _01_Etut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static ve dinamik
            Console.WriteLine();//static bir yapı olduğu için sınıfla beraber çağrılır.
            Random random = new Random();//instance Örneklem yeni nesne oluşturma
          
            random.Next();

            Console.WriteLine("Hesap makinesi");
            Thread.Sleep(2000);
            Console.WriteLine("Birinci değer");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci değer");
            int sayi2=Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine($"İşlem Sonucu: {DegerDonder(sayi, sayi2)}");
        }
        static int DegerDonder(int s, int s2)
        {
            //Geriye değer döndüren bir methodumuz var ise tüm koşullarda ya return ifadesini kullanmalıyız yada en dışarıda değişken deki değeri döndermeliyiz örneğimizdeki gibi
            Console.Clear();
            int deger = 0;
            Console.WriteLine("Yapmak istediğiniz işlemi belirtin \n(+) Toplama \n(-) Çıkarma \n(/) Bölme \n(*) Çarpma \n(%) Modunu Bulma ");
            char cevap = Convert.ToChar(Console.ReadLine());
            if (cevap=='+')
            {
                deger=s+s2;
                //return s+s2;
            }
            else if (cevap=='-')
            {
                deger= s-s2;
                //return s-s2;
            }
            else if (cevap=='/')
            {
                if (s2>0)
                {
                    deger=s/s2;
                    //return s/s2;
                }
                else
                {
                    Console.WriteLine("Sayı Sıfıra bölünemez");
                }
            }
            else if (cevap=='*')
            {
                deger=s*s2;
                //return s*s2;
            }
            else if (cevap=='%')
            {
                if (s%s2==0)
                {
                    if (s2%2==0)
                    {
                        deger=s%s2;
                        Console.WriteLine("Sayı Çiftir "+s);
                    }
                    else
                    {
                        deger=s%s2;
                        Console.WriteLine("Sayı Tektir "+s);
                    }
                }
                else
                {
                    deger=s%s2;
                    Console.WriteLine("Sayı Tektir"+s);

                }
                //return s%s2;
            }
            else
            {
                Console.WriteLine("hatalı işlem");

            }
            return deger;
        }
    }
}
